using UnityEngine;

public class ArrowMovement : MonoBehaviour
{
    [SerializeField] protected float moveSpeed = 5.0f;

    private void FixedUpdate()
    {
        OnArrowMove();
    }

    protected virtual void OnArrowMove()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.fixedDeltaTime, Space.World);
    }
}
