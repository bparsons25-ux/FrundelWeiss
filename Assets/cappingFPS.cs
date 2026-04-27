using UnityEngine;

public class cappingFPS : MonoBehaviour
{
    public enum limits
    {
        nolimit = 0,
        limit30 = 30,
        limit60 = 60,
        limit120 = 120,
        limit240 = 240,
    }

    public limits limit;

    private void Awake()
    {
        Application.targetFrameRate = (int)limit;
    }

}
