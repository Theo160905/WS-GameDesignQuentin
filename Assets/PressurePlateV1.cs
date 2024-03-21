using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateV1 : MonoBehaviour
{ 
    Renderer rend;
    [SerializeField] private GameObject Door;

    private bool IsPressed = false;
    private int Active = 1;

    private void Start()
    {
        rend = GetComponent<Renderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (IsPressed == false)
            {
                IsPressed = true;
                rend.material.color = Color.green;
                Door.gameObject.SendMessage("OpenDoor", Active, SendMessageOptions.DontRequireReceiver);
            }
        }
        if (collision.gameObject.tag == "Caisse")
        {
            if (IsPressed == false)
            {
                IsPressed = true;
                rend.material.color = Color.green;
                Door.gameObject.SendMessage("OpenDoor", Active, SendMessageOptions.DontRequireReceiver);
            }
        }
    }
}
