using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wayPointFollower : MonoBehaviour
{
    [SerializeField] GameObject[] waypoints;
    int currentWayPointIndex = 0;
    [SerializeField] float speed = 1f;


    void Update()
    {
        if(Vector3.Distance(transform.position, waypoints[currentWayPointIndex].transform.position) < .1f)
        {
            currentWayPointIndex++;
            if (currentWayPointIndex >= waypoints.Length)
            {
                currentWayPointIndex = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWayPointIndex].transform.position, speed * Time.deltaTime);

    }
}
