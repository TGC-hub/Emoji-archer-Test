using System.Collections.Generic;
using UnityEngine;

public class CheckerEnemy : MyMonoBehavior
{
    public List<Transform> enemies;
    public bool nextFloor = false;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadEnemy();
    }
    protected override void Start()
    {
        base.Start();
        nextFloor = false;
    }

    private void Update()
    {
        OnNextFloor();
    }

    protected virtual void LoadEnemy()
    {
        if (this.enemies.Count > 0) { return; }
        else
        {
            foreach (Transform prefab in transform)
            {
                this.enemies.Add(prefab);
            }
        }
    }

    protected virtual void OnNextFloor()
    {
        if(this.enemies.Count == 0 && this.nextFloor == true)
        {
            ObserverEnemyDeath.Instance.KillEnemy();
            this.nextFloor = false;
        }
    }

}
