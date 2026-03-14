using UnityEngine;

public class GameEndState : GameState
{
    public GameEndState(GameContext context, GameStateMachine.EState stateKey) : base(context, stateKey)
    {
        Context = context;
    }

    public override void EnterState(GameStateMachine.EState previousKey)
    {
        Debug.Log("Entered Game End State");
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
