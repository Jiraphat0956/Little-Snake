using UnityEngine;

public class GameNoneState : GameState
{
    public GameNoneState(GameContext context, GameStateMachine.EState stateKey) : base(context, stateKey)
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
