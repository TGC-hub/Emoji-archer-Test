using System.Collections;
using UnityEngine;

public class PlayerShooting : MyMonoBehavior
{
    [SerializeField] protected bool onShoot = false;

    protected override void Start()
    {
        base.Start();
        onShoot = true;
    }
    protected virtual void Update()
    {
        SettingShoot();
    }

    protected virtual void SettingShoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && onShoot == true)
        {
            Shooting();
            StartCoroutine(ResetShooter());
            ObserverShot.Instance.PlayerStartShoot();
        }
    }

    protected virtual void Shooting()
    {
        Vector3 pos = transform.position;
        Quaternion rot = transform.rotation;
        Transform prefab = ArrowSpawner.Instance.RandomPrefab();
        Transform obj = ArrowSpawner.Instance.Spawn(prefab, pos, rot);
        obj.gameObject.SetActive(true);
        onShoot = false;
    }

    IEnumerator ResetShooter()
    {
        yield return new WaitForSeconds(3f);
        onShoot = true;
        ObserverShot.Instance.PlayerFinishShoot();
    }

}
