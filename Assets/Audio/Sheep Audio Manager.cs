using UnityEngine;

public class SheepAudioManager : MonoBehaviour
{
    public AudioSource playerSFX;

    [Header("Sheep SFX")]

    public AudioClip lambScream;
    public AudioClip lambBleat;
    public AudioClip femaleSheepBleating;
    public AudioClip deadSheepLift;

    public void Scream()
    {
        playerSFX.PlayOneShot(lambScream);
    }

    public void Bleat()
    {
        playerSFX.PlayOneShot(lambBleat);
    }

    public void GirlBleat()
    {
        playerSFX.PlayOneShot(femaleSheepBleating);
    }

    public void LiftDeadSheep()
    {
        playerSFX.PlayOneShot(deadSheepLift);
    }
}
