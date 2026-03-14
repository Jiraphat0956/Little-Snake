using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameEndPanel: UIPanel
{
    [SerializeField] TextMeshProUGUI gameOverText;

    [SerializeField] TextMeshProUGUI levelText;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI timeText;

    [SerializeField] Button mainMenuButton;


    private void OnEnable()
    {
        mainMenuButton.onClick.AddListener(GoToMainMenu);
    }
    private void OnDisable()
    {
        mainMenuButton.onClick.RemoveListener(GoToMainMenu);
    }
    public void SetPanelInfo(bool isWin, string level, int score, float time)
    {
        gameOverText.text = isWin ? "You Win!" : "Game Over!";
        levelText.text = $"Level: {level}";
        scoreText.text = $"Score: {score}";
        timeText.text = $"Time: {time:F2}s";
    }
    void GoToMainMenu()
    {
        GameStateMachine.Instance.SetBackToMainMenu();
    }
}