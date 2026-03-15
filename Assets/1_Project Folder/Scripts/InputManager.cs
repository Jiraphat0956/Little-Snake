using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : Singleton<InputManager>
{
    InputSystem_Actions _input;
    public delegate void InputDelegate();
    public delegate void InputGenericDelegate<T>(T param);

    public static event InputDelegate OnEscape;

    public static event InputGenericDelegate<Vector2> OnMove;


    protected override void Awake()
    {
        base.Awake();
        _input = new InputSystem_Actions();
        _input.Player.Escape.performed += ctx => OnEscape?.Invoke();

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) OnMove?.Invoke(Vector2.up);
        if (Input.GetKeyDown(KeyCode.S)) OnMove?.Invoke(Vector2.down);
        if (Input.GetKeyDown(KeyCode.A)) OnMove?.Invoke(Vector2.left);
        if (Input.GetKeyDown(KeyCode.D)) OnMove?.Invoke(Vector2.right);
    }

    #region Enable/Disable Input Actions
    private void OnEnable()
    {
        _input?.Enable();
    }
    private void OnDisable()
    {
        _input?.Disable();
    }
    #endregion
}
