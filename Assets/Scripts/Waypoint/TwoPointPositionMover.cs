using UnityEngine;

public class TwoPointPositionMover : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public RouteToPointSO route;
    public float speed = 2f;
    private Vector3 target;
    void Start()
    {
        transform.position = route.pointA;
        target = route.pointB;
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(
        transform.position,
        target,
        speed * Time.deltaTime
        );
        if (transform.position == target)
        {
            target = (target == route.pointA) ? route.pointB : route.pointA;
        }
    }
}
