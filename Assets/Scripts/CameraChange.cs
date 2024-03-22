using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public Transform choix1Position;
    public Transform choix2Position;

    private bool isChoix1 = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (isChoix1)
            {
                transform.position = choix2Position.position;
                transform.rotation = choix2Position.rotation;
                isChoix1 = false;
            }
            else
            {
                transform.position = choix1Position.position;
                transform.rotation = choix1Position.rotation;
                isChoix1 = true;
            }
        }
    }
}
