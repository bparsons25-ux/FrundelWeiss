using UnityEngine;

public class MiscAudioManager : MonoBehaviour
{
    public AudioSource playerSFX;

    public AudioClip BurnSFX;


    public void BurnSheep()
    {
        playerSFX.PlayOneShot(BurnSFX);
    }

}
