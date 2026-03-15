using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class GameState : BaseState<GameStateMachine.EState>
{
    protected GameContext Context;

    public GameState(GameContext context, GameStateMachine.EState stateKey) : base(stateKey)
    {
        Context = context;
    }
    public void SetMouseCursor(bool isVisible)
    {
        if (isVisible)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

}
