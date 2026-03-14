using UnityEngine;

public class GameMenuState : GameState
{
    public GameMenuState(GameContext context, GameStateMachine.EState stateKey) : base(context, stateKey)
    {
        Context = context;
    }

    public override void EnterState(GameStateMachine.EState previousKey)
    {

    }
    public override void UpdateState()
    {

    }

    public override void ExitState(GameStateMachine.EState nextKey)
    {

    }

    public override GameStateMachine.EState GetNextState()
    {
        if (Context.IsPlaying)
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
}
