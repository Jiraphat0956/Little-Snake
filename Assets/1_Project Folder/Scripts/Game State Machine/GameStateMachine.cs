
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
    }

    [SerializeField] GameContext context;
    [SerializeField] EState initialState;// For Test
    public static GameStateMachine Instance { get; private set; }

    public delegate void GameGenericEvent<T>(T param);

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

        CurrentState = States[initialState];// For Test
    }
    public override void Start()
    {
        base.Start();

    }

}