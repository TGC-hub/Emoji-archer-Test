
using UnityEngine;

public class DetroyEnemies : MyMonoBehavior
{
    [SerializeField] protected CheckerEnemy checkerEnemy;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadEnemies();
    }
    protected virtual void LoadEnemies()
    {
        if (checkerEnemy != null) return;
        checkerEnemy = transform.parent.parent.GetComponent<CheckerEnemy>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Arrow"))
        {
            Destroy(this.transform.parent.gameObject);
            ObserverShot.Instance.PlayerFinishShoot();
            checkerEnemy.enemies.Remove(this.transform.parent);
            checkerEnemy.nextFloor = true;
        }
    }
}
