using System.Collections;
using System.Threading.Tasks;
using UnityEngine;

public class AttackEnnemy : MonoBehaviour
{ 
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("AIe2");
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Ennemy")
        {
            Debug.Log("Meurs2");
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        StartCoroutine(ToDestroy());
    }


    private IEnumerator ToDestroy()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
