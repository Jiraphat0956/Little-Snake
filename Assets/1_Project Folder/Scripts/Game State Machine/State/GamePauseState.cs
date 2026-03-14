using UnityEngine;

public class GamePauseState : GameState
{
    public GamePauseState(GameContext context, GameStateMachine.EState stateKey) : base(context, stateKey)
    {
        Context = context;
    }

    public override void EnterState(GameStateMachine.EState previousKey)
    {
        UIManager.Instance.ShowUIPanel(EUIScreen.Pause);

        InputManager.OnEscape += ResumeGame;
    }
    public override void UpdateState()
    {

    }

    public override void ExitState(GameStateMachine.EState nextKey)
    {
        InputManager.OnEscape -= ResumeGame;

    }

    public override GameStateMachine.EState GetNextState()
    {
        if (!Context.IsPause)
        {
            return GameStateMachine.EState.Play;
        }
        return StateKey;
    }

    public override void OnTriggerEnter(Collider other)
    {

    }

    public override void OnTriggerExit(Collider other)
    {

    }

    public override void OnTriggerStay(Collider other)
    {

    }
    void ResumeGame()
    {
        Context.IsPause = false;
    }
}
