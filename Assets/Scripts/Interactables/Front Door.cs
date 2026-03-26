using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class FrontDoor : Interactable
{

    private float ExitFade = 3f;
    //private bool Fade = false;

    void Leave()
    {
        StartCoroutine(Go());
        SceneManager.LoadSceneAsync(0);

    }

    private IEnumerator Go()
    {
        //Fade = true;
        yield return new WaitForSeconds(ExitFade);


    }

    
}
