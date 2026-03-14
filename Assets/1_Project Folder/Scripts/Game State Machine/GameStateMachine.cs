
using StateMachine;
using StateMachine.Local;
using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;
using static GameStateMachine;

public class GameStateMachine : StateManager<GameStateMachine.EState>
{
    public enum EState
    {
        None,
        Menu,
        Play,
        Pause,
        End
    }

    [SerializeField] GameContext context;
    [SerializeField] EState initialState;// For Test
    public static GameStateMachine Instance { get; private set; }

    public delegate void GameGenericEvent<T>(T param);
    public delegate void GameEvent();

    public GameEvent OnGameTick;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        context.StateMachine = this;
        InitializeStates();
    }

    private void InitializeStates()
    {
        States.Add(EState.None, new GameNoneState(context, EState.None));
        States.Add(EState.Menu, new GameMenuState(context, EState.Menu));
        States.Add(EState.Play, new GamePlayState(context, EState.Play));
        States.Add(EState.Pause, new GamePauseState(context, EState.Pause));
        States.Add(EState.End, new GameEndState(context, EState.End));

        CurrentState = States[initialState];// For Test
    }
    public override void Start()
    {
        base.Start();

        SnakeController.Instance.OnSnakeDead += SetGameOver;
    }
    public void SetStartGame()
    { 
        context.IsPlaying = true;
    }
    public void SetGameOver()
    {
        context.IsWin = false;
        context.IsEndGame = true;
    }
    public void SetBackToMainMenu()
    {
        context.IsPlaying = false;
        context.IsEndGame = false;
        context.IsWin = false;
    }

}