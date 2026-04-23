using UnityEngine;

public class NPC_Vehicle : MonoBehaviour
{
    public float speed = 10f;
    public float turnSpeed = 5f;
    public Transform[] waypoints;
    private int currentWaypointIndex = 0;

    void Update()
    {
        MoveToWaypoint();
    }

    void MoveToWaypoint()
    {
        if (currentWaypointIndex < waypoints.Length)
        {
            Transform targetWaypoint = waypoints[currentWaypointIndex];
            Vector3 direction = targetWaypoint.position - transform.position;
            float step = speed * Time.deltaTime;
            
            // Move the vehicle towards the waypoint
            transform.position = Vector3.MoveTowards(transform.position, targetWaypoint.position, step);
            
            // Rotate the vehicle to face the waypoint
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);
            
            // Check if the vehicle has reached the waypoint
            if (Vector3.Distance(transform.position, targetWaypoint.position) < 0.1f)
            {
                currentWaypointIndex++;
            }
        }
    }
}