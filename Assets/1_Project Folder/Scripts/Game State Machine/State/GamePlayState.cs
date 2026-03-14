using UnityEngine;

public class GamePlayState : GameState
{
    public GamePlayState(GameContext context, GameStateMachine.EState stateKey) : base(context, stateKey)
    {
        Context = context;
    }

    public override void EnterState(GameStateMachine.EState previousKey)
    {
        InputManager.OnMove += MoveSnake;
    }
    public override void UpdateState()
    {
        Context.TickTime += Time.deltaTime;
        if (Context.TickTime >= Context.currentLevelData.TickTime)
        {
            Context.StateMachine.OnGameTick?.Invoke();
            Context.TickTime = 0;
        }
    }

    public override void ExitState(GameStateMachine.EState nextKey)
    {
        InputManager.OnMove -= MoveSnake;
    }

    public override GameStateMachine.EState GetNextState()
    {
        if (Context.IsEndGame)
        {
            return GameStateMachine.EState.End;
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

    void MoveSnake(Vector2 direction)
    {
        bool changeDirectionSuccess = SnakeController.Instance.ChangeDirection(direction);
        if (!changeDirectionSuccess) return;
        Context.TickTime = 0; 
        Context.StateMachine.OnGameTick?.Invoke();
    }
}
