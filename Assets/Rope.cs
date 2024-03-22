using UnityEngine;

public class Rope : MonoBehaviour
{
    [SerializeField] private LineRenderer lineRenderer;
    [SerializeField] private GameObject Door;
    [SerializeField] private Vector3 PointB;
    [SerializeField] private Vector3 PointC;

    private int Active = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PointB")
        {
            if (lineRenderer != null && lineRenderer.positionCount > 0 )
            {
                Vector3 lastPoint = lineRenderer.GetPosition(lineRenderer.positionCount - 1);
                Debug.Log("Position de la dernière case : " + lastPoint);
                if (lastPoint == PointB || lastPoint == PointC)
                {
                    Debug.Log("Yeye");
                    Door.gameObject.SendMessage("OpenDoor", Active, SendMessageOptions.DontRequireReceiver);
                }
            }
        }
    }
}
