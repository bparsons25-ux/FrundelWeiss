using UnityEngine;

public class CamLook : MonoBehaviour
{
    public Camera cam;
    private float xRotation = 0f;

    public float xSensitivity = 45f;
    public float ySenstivity = 45f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void ProcessLook(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;

        // calculate camera rotation for looking up and down
        xRotation -= (mouseY * Time.deltaTime) * ySenstivity;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        // apply this to our camera transforms 
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // rotate player to look left and right
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSensitivity);
    }


 
}
