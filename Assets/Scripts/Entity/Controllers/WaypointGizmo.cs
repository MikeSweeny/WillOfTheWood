using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointGizmo : MonoBehaviour
{
    public float size = 1f;
    private Transform[] waypoints;
    public Color color;

    //Function: prebuilt OnDrawGizmos
    //DESCRIPTION: this function is being used to draw lines between waypoints and a sphere on the waypoints themselves
    //PARAMETERS: Vector3 last
    //RETURNS: None
    private void OnDrawGizmos()
    {
        waypoints = gameObject.GetComponentsInChildren<Transform>();
        Vector3 last = waypoints[waypoints.Length - 1].position;
        int n = waypoints.Length;
        for (int i = 1; i < n; i++)
        {
            Gizmos.color = color;
            Gizmos.DrawSphere(waypoints[i].position, size);
            Gizmos.DrawLine(last, waypoints[i].position);
            last = waypoints[i].position;
        }
    }
}
