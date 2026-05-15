using UnityEngine;

public class UISFXManager : MonoBehaviour
{
    public AudioSource GeneralSFX;

    public AudioClip pauseMenuOn;
    public AudioClip pauseMenuOff;
    public AudioClip buttonClick;

    public void PauseOn()
    {
        GeneralSFX.PlayOneShot(pauseMenuOn);
    }

    public void PauseOff()
    {
        GeneralSFX.PlayOneShot(pauseMenuOff);
    }

    public void ButtonClick()
    {
        GeneralSFX.PlayOneShot(buttonClick);
    }

}
