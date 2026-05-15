using JetBrains.Annotations;
using UnityEngine;

public class EnviromentAudioManager : MonoBehaviour
{
    public AudioSource door;


    [Header("Room Noises")]

    public AudioClip doorShut;
    public AudioClip doorOpen;


    public void DoorOpen()
    {
        door.PlayOneShot(doorOpen);
    }

    public void DoorClose()
    {
        door.PlayOneShot(doorShut);
    }




}
