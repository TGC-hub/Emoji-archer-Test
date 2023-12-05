using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGoodHuman : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Arrow"))
        {
            Destroy(this.transform.parent.gameObject);
            ObserverWinLose.Instance.PlayerLose();
        }
    }
}
