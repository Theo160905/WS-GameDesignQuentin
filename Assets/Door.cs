using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    BoxCollider boxcollider;
    [SerializeField] private int DoorOpen = 0;
    private int ObjectActivate= 0;

    public string scenename;

    private void Start()
    {
        boxcollider = GetComponent<BoxCollider>();
        boxcollider.enabled = false;
    }

    public void OpenDoor(int ActiveDoor)
    {
        ObjectActivate += ActiveDoor ;
        Debug.Log(ObjectActivate);
        if (ObjectActivate >= DoorOpen)
        {
            boxcollider.enabled = true;
        }
        else if (ObjectActivate == 0)
        {
            boxcollider.enabled = false;
        }
        else if (ObjectActivate != 0 && ObjectActivate != DoorOpen) 
        {
            boxcollider.enabled = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(scenename);
            Debug.Log("AHHH");
        }

    }
}
