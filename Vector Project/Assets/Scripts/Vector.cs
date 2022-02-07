using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector : MonoBehaviour
{
    public Transform A;
    public Transform B;

    public float abDistance;
    private void OnDrawGizmos()
    {
        Vector2 point = transform.position;
        Vector2 pointA = A.position;
        Vector2 pointB = B.position;

        Vector2 atoB = pointB - pointA;
        Vector2 atoBDir = atoB.normalized;
        abDistance = Vector2.Distance(pointA, pointB);

        Gizmos.DrawLine(pointA, pointA + atoBDir);

        Gizmos.DrawLine(Vector2.zero, point);
    }
}
