
using UnityEngine;
[System.Serializable]
public class GameContext
{
    public GameStateMachine StateMachine { get; set; }
    public bool IsPlayCutscene { get; set; }
    public bool IsPlayDialogue { get; set; }
    public bool IsUsePhone { get; set; }
}
