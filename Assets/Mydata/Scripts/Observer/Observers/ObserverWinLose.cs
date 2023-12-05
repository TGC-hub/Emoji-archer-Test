using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverWinLose : MyMonoBehavior
{
    private static ObserverWinLose instance;
    public static ObserverWinLose Instance => instance;

    private List<IObserverWinLose> observers = new List<IObserverWinLose>();

    protected override void Awake()
    {
        base.Awake();
        if (instance != null) return;
        instance = this;
    }

    public void AddObserver(IObserverWinLose observerShot)
    {
        observers.Add(observerShot);
    }

    public void RemoveObserver(IObserverWinLose observerShot)
    {
        observers.Remove(observerShot);
    }

    public void PlayerWin()
    {
        foreach (IObserverWinLose observer in observers)
        {
            observer.SendMessYouWin();
        }
    }

    public void PlayerLose()
    {
        foreach (IObserverWinLose observer in observers)
        {
            observer.SendMessYouLoss();
        }
    }
}
