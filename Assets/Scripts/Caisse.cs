using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caisse : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField] private GameObject Camera;
    [SerializeField] private GameObject CameraPosition1;
    [SerializeField] private GameObject CameraPosition2;


    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotation;
        rb.constraints = RigidbodyConstraints.FreezePositionY;
    }

    void Update()
    {
        if (Camera.transform.position == CameraPosition1.transform.position)
        {
            rb.constraints = RigidbodyConstraints.FreezePositionZ;
        }

        if (Camera.transform.position == CameraPosition2.transform.position)
        {
            rb.constraints = RigidbodyConstraints.FreezePositionX; 
        }
    }
}
