using UnityEngine;
using UnityEngine.UI;

public class MainMenuPanel : UIPanel
{
    [SerializeField] Button startButton;

    private void OnEnable()
    {
        startButton.onClick.AddListener(StartGame);
    }
    private void OnDisable()
    {
        startButton.onClick.RemoveListener(StartGame);

    }

    void StartGame()
    {
        GameStateMachine.Instance.SetStartGame();
    }
}
