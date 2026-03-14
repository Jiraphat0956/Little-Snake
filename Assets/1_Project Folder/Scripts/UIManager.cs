using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class UIManager : Singleton<UIManager>
{

    [SerializeField] List<UIPanel> UIPanelList;
    #region Setup
    private void Awake()
    {
        SetupPanels();
    }
    private void Start()
    {

    }
    void SetupPanels()
    {

    }
    #endregion

    #region Gameplay

    #endregion

}
