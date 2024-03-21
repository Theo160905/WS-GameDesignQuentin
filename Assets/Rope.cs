using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
    [SerializeField] private LineRenderer lineRenderer;
    [SerializeField] private GameObject Door;
    [SerializeField] private Vector3 PointB;

    private int Active = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PointB")
        {
            if (lineRenderer != null && lineRenderer.positionCount > 0)
            {
                Vector3 lastPoint = lineRenderer.GetPosition(lineRenderer.positionCount - 1);
                Debug.Log("Position de la dernière case : " + lastPoint);
                if (lastPoint == PointB)
                {
                    Door.gameObject.SendMessage("OpenDoor", Active, SendMessageOptions.DontRequireReceiver);
                }
            }
        }
    }
}
