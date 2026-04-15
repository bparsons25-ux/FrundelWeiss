using UnityEngine;

public class GeneralFunctions : MonoBehaviour
{
    [SerializeField] CamLook Look;
    [SerializeField] PlayerMovement pm;

    private void Start()
    {
        pm  = GetComponent<PlayerMovement>();
    }


    public void MouseLock()
    {
        Cursor.lockState = CursorLockMode.Locked;

    }

    public void MouseUnlock()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void CamLock()
    {
        Look.xSensitivity = 0f;
        Look.ySenstivity = 0f;


    }

    public void CamUnlock()
    {
        Look.xSensitivity = 20f;
        Look.ySenstivity = 20f;
      

    }

}
