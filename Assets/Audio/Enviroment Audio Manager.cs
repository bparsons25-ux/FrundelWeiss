using UnityEngine;

public class EnviromentAudioManager : MonoBehaviour
{
    public AudioSource playerSFX;

    public AudioClip BurnSFX;


    public void BurnSheep()
    {
        playerSFX.PlayOneShot(BurnSFX);
    }

}
