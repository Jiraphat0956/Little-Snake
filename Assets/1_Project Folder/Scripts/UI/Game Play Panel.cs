using TMPro;
using UnityEngine;

public class GamePlayPanel: UIPanel
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI timeText;

    public void SetScoreText(int score, int goal) => scoreText.text = $"Score: {score}/{goal}";
    public void SetTimeText(float time)=> timeText.text = $"Score: {time}";
}
