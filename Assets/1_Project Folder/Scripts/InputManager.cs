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


        _input.Player.Move.performed += ctx => { OnMove?.Invoke(ctx.ReadValue<Vector2>()); };
        //_input.Player.Move.canceled += ctx => {  OnMove?.Invoke(Vector2.zero); };

        _input.Player.Escape.performed += ctx => OnEscape?.Invoke();

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
