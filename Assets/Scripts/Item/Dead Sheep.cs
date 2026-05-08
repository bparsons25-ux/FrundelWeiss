using Unity.VisualScripting;
using UnityEngine;

public class DeadSheep : MonoBehaviour
{


    private void Start()
    {
        //transform.Rotate(Vector3.right, 90);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("pCylinder44"))
        { 
            Destroy(gameObject);


        }
        

    }


}
