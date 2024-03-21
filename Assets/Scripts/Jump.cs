 using System.Threading.Tasks;
using UnityEngine;

public class Jump : MonoBehaviour
{
   
    private float grounddistance = 0.5f;
    private float jumpforce = 5f;

    Rigidbody rb;

    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, grounddistance);
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            rb.velocity = Vector3.up * jumpforce;
            Debug.Log(rb);
            Debug.Log(rb.velocity);
        }
    }
}
