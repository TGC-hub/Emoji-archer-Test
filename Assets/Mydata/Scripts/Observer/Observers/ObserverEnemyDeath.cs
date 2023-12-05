using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverEnemyDeath : MyMonoBehavior
{
    private static ObserverEnemyDeath instance;
    public static ObserverEnemyDeath Instance => instance;

    private List<IObserverEnemyDeath> observers = new List<IObserverEnemyDeath>();

    protected override void Awake()
    {
        base.Awake();
        if (instance != null) return;
        instance = this;
    }

    public void AddObserver(IObserverEnemyDeath observerShot) 
    {
        observers.Add(observerShot);
    }

    public void RemoveObserver(IObserverEnemyDeath observerShot) 
    {
        observers.Remove(observerShot);
    }

    public void KillEnemy()
    {
        foreach(IObserverEnemyDeath observer in observers) 
        {
            observer.DownPositon();
        }
    }

}
