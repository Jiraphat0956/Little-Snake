using TMPro;
using UnityEngine;

public class GamePausePanel: UIPanel
{
    [SerializeField] TextMeshProUGUI levelText;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI timeText;

    public void UpdatePanelInfo(int level, int score, float time)
    {
        levelText.text = $"Level: {level}";
        scoreText.text = $"Score: {score}";
        timeText.text = $"Time: {time:F2}s";
    }
}
