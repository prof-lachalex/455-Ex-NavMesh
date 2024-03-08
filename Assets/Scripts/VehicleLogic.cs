using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class VehicleLogic : MonoBehaviour
{
    NavMeshAgent agent;
    List<Vector3> waypoints;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        waypoints = new List<Vector3>();
        GameObject waypointObject = GameObject.Find("Waypoints");
        foreach (Transform t in waypointObject.GetComponentsInChildren<Transform>())
        { 
            waypoints.Add(t.position);
        }
        // GetComponentsInChildren retourne aussi le parent ...
        waypoints.Remove(waypointObject.transform.position);

        agent.SetDestination(waypoints[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
