//FILE: NpcPathing.cs
//PROJECT: Will Of The Woods
//PROGRAMMER: John Gotts
//FIRST VERSION: 10/12/2019

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//NAME: NpcPathing
//PURPOSE: this calss will be used to determine the general movement for enemies and NPCs
public class NpcPathing : MonoBehaviour
{
    private NavMeshAgent agent;

    public Transform WaypointContainer;
    public Transform[] waypoints;
    public BaseNpc[] enemy;
    public GameObject target;
    public Transform[] fleeingPoints;
    public Transform fleeingDestinationContainer;
    private Transform[] waypoint;
    private int currentWaypoint = 0;
    public float distanceToCover = 1f;

    private float[] distanceLeftToTravel;


    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if (WaypointContainer)
        {
            GetWaypoints();
        }
        waypoint = new Transform[enemy.Length];
        distanceLeftToTravel = new float[enemy.Length];

        for (int i = 0; i < enemy.Length; i++)
        {
            distanceLeftToTravel[i] = float.MaxValue;
        }
    }

    //Function: RoamingPath
    //DESCRIPTION: this class is used to allow the enemies and NPCs to move around their predetermined paths
    //PARAMETERS: Vector3 relativeWaypointPosition, Transform nextWaypoint, float distanceCovered
    //RETURNS: None
    public void RoamingPath()
    {
        Vector3 relativeWaypointPosition = transform.InverseTransformPoint(new Vector3(waypoints[currentWaypoint].position.x, transform.position.y, waypoints[currentWaypoint].position.z));

        for (int i = 0; i < enemy.Length; i++)
        {
            Transform nextWaypoint = GetCurrentWaypoint();
            float distanceCovered = (nextWaypoint.position - transform.position).magnitude;

            if (distanceLeftToTravel[i] - distanceToCover > distanceCovered ||
                waypoint[i] != nextWaypoint)
            {
                waypoint[i] = nextWaypoint;
                distanceLeftToTravel[i] = distanceCovered;
            }

            if (relativeWaypointPosition.magnitude < 5)
            {
                currentWaypoint++;
                if (currentWaypoint >= waypoints.Length)
                {
                    currentWaypoint = 0;
                }
            }
            agent.SetDestination(GetCurrentWaypoint().position);
        }
    }

    //Function: FleeingPath
    //DESCRIPTION: this function is used for enemies to flee from the player to whichever point is furthest from the player in a container of points
    //PARAMETERS: float furthestDistanceSoFar, Vector3 fleePosition, Transform[] potentialDestinations, float currentDistanceCheck, Transform point
    //RETURNS: None
    public void FleeingPath()
    {
        float furthestDistanceSoFar = 0;
        Vector3 fleePosition = Vector3.zero;

        Transform[] potentialDestinations = fleeingDestinationContainer.GetComponentsInChildren<Transform>();
        fleeingPoints = new Transform[(potentialDestinations.Length - 1)];
        if(target)
        {
            foreach (Transform point in potentialDestinations)
            {
                float currentDistanceCheck = Vector3.Distance(target.transform.position, point.position);
                if (currentDistanceCheck > furthestDistanceSoFar)
                {
                    furthestDistanceSoFar = currentDistanceCheck;
                    fleePosition = point.position;
                }
            }

            agent.SetDestination(fleePosition);
        }
    }

    //Function: GetWaypoints
    //DESCRIPTION: this function is used to gather all the waypoints in the waypoint container
    //PARAMETERS: Transform[] potentialWaypoints
    //RETURNS: None
    void GetWaypoints()
    {
        Transform[] potentialWaypoints = WaypointContainer.GetComponentsInChildren<Transform>();
        waypoints = new Transform[(potentialWaypoints.Length - 1)];

        for (int i = 1; i < potentialWaypoints.Length; i++)
        {
            waypoints[i - 1] = potentialWaypoints[i];
        }
    }

    //Function: GetNavMeshAgent
    //DESCRIPTION: this function is used to get the NavMeshAgent
    //PARAMETERS: None
    //RETURNS: NavMeshAgent agent
    public NavMeshAgent GetNavMeshAgent()
    {
        return agent;
    }

    //Function: GetCurrentWaypoint
    //DESCRIPTION: this function is used to get the current waypoint that the object is on in its cycle through the waypoints
    //PARAMETERS: None
    //RETURNS: Transform waypoints[currentWaypoint]
    public Transform GetCurrentWaypoint()
    {
        return waypoints[currentWaypoint];
    }
}
