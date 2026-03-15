using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.Video;

public class UIManager : Singleton<UIManager>
{

    [SerializeField] List<UIPanel> UIPanelList;

    MainMenuPanel _mainMenuPanel;
    GamePlayPanel _gamePlayPanel;
    GamePausePanel _pausePanel;
    GameEndPanel _gameEndPanel;

    #region Setup
    private void Awake()
    {
        SetupPanels();
    }
    void SetupPanels()
    {
        _mainMenuPanel = UIPanelList.First(panel => panel is MainMenuPanel) as MainMenuPanel;
        _gamePlayPanel = UIPanelList.First(panel => panel is GamePlayPanel) as GamePlayPanel;
        _pausePanel = UIPanelList.First(panel => panel is GamePausePanel) as GamePausePanel;
        _gameEndPanel = UIPanelList.First(panel => panel is GameEndPanel) as GameEndPanel;
    }
    public void ShowUIPanel(EUIScreen screen)
    {
        for(int i = 0; i< UIPanelList.Count; i++)
        {
            UIPanelList[i].gameObject.SetActive(i == (int)screen);
        }
    }
    #endregion

    #region Gameplay
    public void UpdateGamePlayScore(int score, int goal)
    {
        _gamePlayPanel.SetScoreText(score, goal);
    }
    public void UpdateGamePlayPlayTime(float time)
    {
        _gamePlayPanel.SetTimeText(time);
    }
    #endregion

    #region End Game
    public void UpdateEndGameInfo(bool isWin, string level,int score, float playtime)
    {
        _gameEndPanel.SetPanelInfo(isWin, level, score, playtime);
    }
    #endregion
}
