using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverShot : MyMonoBehavior
{
    private static ObserverShot instance;
    public static ObserverShot Instance => instance;

    private List<IObserverShot> observers = new List<IObserverShot>();

    protected override void Awake()
    {
        base.Awake();
        if (instance != null) return;
        instance = this;
    }

    public void AddObserver(IObserverShot observerShot) 
    {
        observers.Add(observerShot);
    }

    public void RemoveObserver(IObserverShot observerShot) 
    {
        observers.Remove(observerShot);
    }

    public void PlayerStartShoot()
    {
        foreach(IObserverShot observer in observers) 
        {
            observer.StartShootArrow();
        }
    }

    public void PlayerFinishShoot()
    {
        foreach (IObserverShot observer in observers)
        {
            observer.FinishShootArrow();
        }
    }
}
