using UnityEngine;

public class BaseMovement : MyMonoBehavior
{
    [SerializeField] protected Transform[] waypoints;
    [SerializeField] protected float speed = 3.0f;
    [SerializeField] protected float initialSpeed;
    private int currentWaypointIndex = 0;

    protected override void Start()
    {
        base.Start();
        initialSpeed = speed;
    }
    protected virtual void FixedUpdate()
    {
        if (waypoints.Length == 0)
        {
            return;
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].position, speed * Time.fixedDeltaTime);

        transform.LookAt(waypoints[currentWaypointIndex].position);

        float distanceToTarget = Vector3.Distance(transform.position, waypoints[currentWaypointIndex].position);

        if (distanceToTarget < 0.1f)
        {
            if (currentWaypointIndex < waypoints.Length - 1)
            {
                currentWaypointIndex++;
            }
            else
            {
                System.Array.Reverse(waypoints);
                currentWaypointIndex = 0;
            }
        }
    }
}
