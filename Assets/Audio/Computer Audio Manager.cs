using UnityEngine;

public class ComputerAudioManager : MonoBehaviour
{
    public AudioSource ComputerAudio;

    [Header("Computer Sounds")]

    public AudioClip computerStartUpSfx;
    public AudioClip computerLogOffSfx;

    [Header("Message and social Media app SFX")]
    public AudioClip messageReceivedSfx;
    public AudioClip messageSentSfx;
    public AudioClip UiKeyboardClick;
    public AudioClip UiMouseClick;

    [Header("Misc SFX")]
    public AudioClip UiButtonClickSfx;
    public AudioClip computerBuzzSfx;

    [Header("Computer Buzz Boolean")]

    private bool computerIsOn;

    private void Start()
    {
        computerIsOn = false;
    }

    private void Update()
    {
        if (computerIsOn == true)
        {
            ComputerAudio.clip = computerBuzzSfx;
            ComputerAudio.loop = true;
            ComputerAudio.Play();
        }
         else if (computerIsOn == false)
        {
            ComputerAudio.clip = null;
            ComputerAudio.loop = false;
            ComputerAudio.Play();
        }
    }

    public void TurnOn()
    {
        computerIsOn = true;
        ComputerAudio.PlayOneShot(computerStartUpSfx);
    }

    public void TurnOff()
    {
        computerIsOn = false;
        ComputerAudio.PlayOneShot(computerLogOffSfx);
    }

    public void Type()
    {
        ComputerAudio.PlayOneShot(UiKeyboardClick);
    }

    public void MessageSent()
    {
        ComputerAudio.PlayOneShot(messageSentSfx);
    }

    public void MessageRecieved()
    {
        ComputerAudio.PlayOneShot(messageReceivedSfx);
    }

    public void ButtonClickSFX()
    {
        ComputerAudio.PlayOneShot(UiButtonClickSfx);
    }

    public void MouseClick()
    {
        ComputerAudio.PlayOneShot(UiMouseClick);
    }
}
