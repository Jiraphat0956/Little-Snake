using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuPanel : UIPanel
{
    [SerializeField] Button startButton;
    [SerializeField] Button exitButton;
    [SerializeField] TMP_Dropdown LevelDropdown;

    private void OnEnable()
    {
        startButton.onClick.AddListener(StartGame);
        exitButton.onClick.AddListener(ExitGame);
    }
    private void OnDisable()
    {
        startButton.onClick.RemoveListener(StartGame);
        exitButton.onClick.RemoveListener(ExitGame);

    }

    void StartGame()
    {
        GameStateMachine.Instance.SetStartGame(LevelDropdown.value);
    }
    void ExitGame()
    {
        Application.Quit();
    }
}
