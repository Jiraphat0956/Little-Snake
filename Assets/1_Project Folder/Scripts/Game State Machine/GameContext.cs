
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class GameContext
{
    public List<SO_LevelData> levelDataList;
    public GameStateMachine StateMachine { get; set; }
    public SO_LevelData currentLevelData { get; set; }
    public float TickTime{ get; set; }
    public bool IsPlaying { get; set; }
    public bool IsPause { get; set; }
    public bool IsWin { get; set; }
    public bool IsEndGame { get; set; }

    public int CurrentLevelIndex { get; set; }
    public int CurrentScore { get; set; }
    public float CurrentPlayTime { get; set; }

}
