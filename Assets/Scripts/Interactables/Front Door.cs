using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class FrontDoor : Interactable
{
    private bool Fade = false;
    private float Fadetime = 3f;
    public GameObject Fadescreen;

    protected override void Interact()
    {
        StartCoroutine(leave());
        //Cursor.lockState = CursorLockMode.None;
        
    }

    IEnumerator leave()
    {
        Fade = true;
        Fadescreen.SetActive(true);
        
        yield return new WaitForSeconds(Fadetime);
        SceneManager.LoadSceneAsync(0);
    }
}
