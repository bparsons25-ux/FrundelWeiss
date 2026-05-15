using UnityEngine;

public class OrganAudioManager : MonoBehaviour
{
    public AudioSource playerAudio;

    [Header("Organ Handling")]

    public AudioClip goreHandlingSfx1;

    [Header("Organ Harvesting")]

    public AudioClip bloodSplatter1;

    public AudioClip wetSlicingSfx1;

    [Header("Misc Sound")]

    public AudioClip heartRateMonitor;


    public void BloodSplatter()
    {
        playerAudio.PlayOneShot(bloodSplatter1);
    }

    public void SlowCutting()
    {
        playerAudio.PlayOneShot(wetSlicingSfx1);
    }

    public void RateMonitor()
    {
        playerAudio.PlayOneShot(heartRateMonitor);
    }

    public void HandleOrgans()
    {
        playerAudio.PlayOneShot(goreHandlingSfx1);
    }


}
