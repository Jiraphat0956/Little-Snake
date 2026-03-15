using UnityEngine;

[CreateAssetMenu(fileName = "SO_LevelData", menuName = "Scriptable Objects/SO_LevelData")]
public class SO_LevelData : ScriptableObject
{
    public string DisplayName;
    public float TickTime;
    public int Goal;
}
