using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGamePlayManager : MyMonoBehavior, IObserverWinLose
{
    [SerializeField] protected LoseAppear panelLose;
    [SerializeField] protected WinAppear panelWin;

    protected override void Start()
    {
        base.Start();
        ObserverWinLose.Instance.AddObserver(this);
    }
    public void SendMessYouLoss()
    {
        panelLose.Appear();
    }

    public void SendMessYouWin()
    {
        panelWin.Appear();
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadPanelLose();
        LoadPanelWin();
    }

    protected virtual void LoadPanelLose()
    {
        if (panelLose != null) return;
        panelLose = transform.Find("PanelLose").GetComponent<LoseAppear>();
    }
    protected virtual void LoadPanelWin()
    {
        if (panelWin != null) return;
        panelWin = transform.Find("PanelWin").GetComponent<WinAppear>();
    }



}
