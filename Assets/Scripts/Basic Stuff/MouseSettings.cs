using UnityEngine;
using UnityEngine.InputSystem;

public class MouseSettings : MonoBehaviour
{

    void MouseUnlock()
    {
        Cursor.lockState = CursorLockMode.None;
        
    }

    void MouseLock()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }



}
