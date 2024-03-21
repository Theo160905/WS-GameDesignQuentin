using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    private float speed = 100.0f;

    [SerializeField] private GameObject Camera;
    [SerializeField] private GameObject CameraPosition1;
    [SerializeField] private GameObject CameraPosition2;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        rb.velocity = Vector3.zero;
        if (Camera.transform.position == CameraPosition1.transform.position)
        {
            if (Input.GetKeyDown("w"))
            {
                transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);
            }

            if (Input.GetKeyDown("s"))
            {
                transform.Translate(Vector3.back * speed * Time.deltaTime, Space.World);
            }
        }

        else if (Camera.transform.position == CameraPosition2.transform.position)
        {
            if (Input.GetKeyDown("d"))
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);
            }

            if (Input.GetKeyDown("a"))
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
            }
        }
    }
}
