using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneDown : MonoBehaviour, IObserverEnemyDeath
{
    [SerializeField] protected Vector3 posStart;
    [SerializeField] protected float downSpeed = 5.0f;
    private void Start()
    {
        posStart = transform.position;
        ObserverEnemyDeath.Instance.AddObserver(this);
    }

    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, posStart, downSpeed * Time.fixedDeltaTime);
    }
    public void DownPositon()
    {
        posStart.y -= 4;
    }
}
