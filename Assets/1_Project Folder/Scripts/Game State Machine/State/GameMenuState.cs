using UnityEngine;

public class GameMenuState : GameState
{
    public GameMenuState(GameContext context, GameStateMachine.EState stateKey) : base(context, stateKey)
    {
        Context = context;
    }

    public override void EnterState(GameStateMachine.EState previousKey)
    {
        UIManager.Instance.ShowUIPanel(EUIScreen.MainMenu);
        FoodSpawner.Instance.ResetFood();
        SnakeController.Instance.ResetSnake();
        Context.CurrentScore = 0;
        UIManager.Instance.UpdateGamePlayScore(Context.CurrentScore, 0);
    }
    public override void UpdateState()
    {

    }

    public override void ExitState(GameStateMachine.EState nextKey)
    {
        if(nextKey == GameStateMachine.EState.Play)FoodSpawner.Instance.SpawnFood();
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
