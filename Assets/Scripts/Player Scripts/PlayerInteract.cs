using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private Camera cam;
    [SerializeField] private float distance = 3f;
    [SerializeField] private LayerMask mask;
    private PlayerUI UI;
    private InputManager InputManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = GetComponent<CamLook>().cam;
        UI = GetComponent<PlayerUI>();
        InputManager = GetComponent<InputManager>();
    }

    // Update is called once per frame
    void Update()
    {
        UI.UpdateText(string.Empty);
        // create a ray at the center of the camera, shooting outwards
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance);
        RaycastHit hitInfo; // variable to store our collision infomation;

        if (Physics.Raycast(ray, out hitInfo, distance, mask))
        {
            if (hitInfo.collider.GetComponent<Interactable>() != null)
            {
                Interactable interactble = hitInfo.collider.GetComponent<Interactable>();
                UI.UpdateText(interactble.promptMessage);
                if (InputManager.onfoot.Interact.triggered)
                {
                    interactble.BaseInteract();
                }
            }
        }
    }
}
