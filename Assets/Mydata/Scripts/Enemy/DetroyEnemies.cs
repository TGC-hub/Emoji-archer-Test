using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetroyEnemies : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Arrow"))
        {
            Destroy(this.transform.parent.gameObject);
            ObserverShot.Instance.PlayerFinishShoot();
            ObserverEnemyDeath.Instance.KillEnemy();
        }
    }
}
