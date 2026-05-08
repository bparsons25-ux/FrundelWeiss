using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class FrontDoor : MonoBehaviour
{

    public bool canOpen;
    public bool isOpen;


    public Transform openPos;
    public Transform closePos;

    private void Start()
    {
        canOpen = true;
        isOpen = false;



    }

    private void Update()
    {
        if (isOpen == false)
        {
            gameObject.transform.position = closePos.transform.position;
            gameObject.transform.rotation = closePos.transform.rotation;
        }

        if (isOpen == true)
        {
            gameObject.transform.position = openPos.transform.position;
            gameObject.transform.rotation = openPos.transform.rotation;
        }

    }

    public void OpenDoor()
    {
        if (isOpen == false)
        {
            isOpen = true;
        }

        if (isOpen == true)
        {
            isOpen = false;
        }
 

        
    }

}
