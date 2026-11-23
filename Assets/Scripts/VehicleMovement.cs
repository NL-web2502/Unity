using UnityEngine;

public class VehicleMovement : MonoBehaviour
{
    [Header("Настройки движения")]
    public float speed = 2f;           
    public Transform[] waypoints;      

    private int currentWaypointIndex = 0;  

    void Start()
    {
         if (waypoints.Length > 0)
        {
            transform.position = waypoints[0].position;
            currentWaypointIndex = 1; 
        }
    }

    void Update()
    {
        if (waypoints.Length == 0 || currentWaypointIndex >= waypoints.Length)
            return;

        Transform target = waypoints[currentWaypointIndex];
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
 
        if (Vector3.Distance(transform.position, target.position) < 0.1f)
        {
            currentWaypointIndex++;
            
            if (currentWaypointIndex >= waypoints.Length)
            {
               Destroy(gameObject);  
            }
        }
    }
}