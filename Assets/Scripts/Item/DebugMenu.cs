using UnityEngine;

public class DebugMenu : MonoBehaviour
{
    public GameObject DebugUserinterface;

    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha6) && Input.GetKey(KeyCode.Alpha7))
        {
            DebugUserinterface.gameObject.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }

        else
        {
            DebugUserinterface.gameObject.SetActive(false);

        }

    }

}
