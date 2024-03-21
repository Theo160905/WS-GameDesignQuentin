using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateV2 : MonoBehaviour
{
    Renderer rend;

    [SerializeField] private GameObject Door;

    private bool IsPressed = false;

    private int Active = 1;
    private int Disabled = -1;

    private void Start()
    {
        rend = GetComponent<Renderer>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (IsPressed == false)
            {
                IsPressed = true;
                rend.material.color = Color.green;
                Door.gameObject.SendMessage("OpenDoor", Active, SendMessageOptions.DontRequireReceiver);
            }
        }        

        if (other.gameObject.tag == "Caisse")
        {
            if (IsPressed == false)
            {
                IsPressed = true;
                rend.material.color = Color.green;
                Door.gameObject.SendMessage("OpenDoor", Active, SendMessageOptions.DontRequireReceiver );
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (IsPressed == true)
            {
                IsPressed = false;
                rend.material.color = Color.red;
                Door.gameObject.SendMessage("OpenDoor", Disabled, SendMessageOptions.DontRequireReceiver);
            }
        }
        if (other.gameObject.tag == "Caisse")
        {
            if (IsPressed == true)
            {
                IsPressed = false;
                rend.material.color = Color.red;
                Door.gameObject.SendMessage("OpenDoor", Disabled, SendMessageOptions.DontRequireReceiver);
            }
        }
    }
}
