using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorStatement : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Arrow"))
        {
            ObserverWinLose.Instance.PlayerWin();
        }
    }
}
