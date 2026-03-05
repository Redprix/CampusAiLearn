using UnityEngine;

[CreateAssetMenu(fileName = "Route2PointPos", menuName = "Waypoint/Route 2 Point (Position)")]
public class RouteToPointSO : ScriptableObject
{
    public Vector3 pointA;
    public Vector3 pointB;
}
