using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    private float speed = 225.0f;

    [SerializeField] private GameObject Camera;
    [SerializeField] private GameObject CameraPosition1;
    [SerializeField] private GameObject CameraPosition2;

    [SerializeField] private GameObject Arm;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        Physics.gravity = new Vector3(0,-120,0);
    }

    private void Update()
    {
        rb.velocity = Vector3.zero;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Arm, transform.position, Quaternion.identity);
        }
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
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }

            if (Input.GetKeyDown("a"))
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
        }
    }
}
