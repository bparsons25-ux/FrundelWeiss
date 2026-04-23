using UnityEngine;

public class InputManager : MonoBehaviour
{

    private PlayerInput playerInput;
    public PlayerInput.OnFootActions onfoot;

    private PlayerMovement movement;
    private CamLook cam;
    private OrganHarvesting organ;
    private PickUpRaycastScript ray;


    private void Awake()
    {
        playerInput = new PlayerInput();
        onfoot = playerInput.OnFoot;
        movement = GetComponent<PlayerMovement>();
        ray = GetComponent<PickUpRaycastScript>();
        cam = GetComponent<CamLook>();
        onfoot.Jump.performed += ctx => movement.Jump(); // ctx is callback context
        onfoot.Sprint.performed += ctx => movement.Sprint();
        onfoot.Crouch.performed += ctx => movement.Crouch();
        onfoot.Pause.performed += ctx => movement.Pause();
        onfoot.PickUp.performed += ctx => ray.PickUp();
        onfoot.Drop.performed += ctx => ray.Drop();
        onfoot.Use.performed += ctx => ray.Use();


    }

    private void OnEnable()
    {
        onfoot.Enable();
    }

    private void OnDisable()
    {
        onfoot.Disable();
    }

    private void FixedUpdate()
    {
        // tell the playermovement to move using the value from the movement action
        movement.ProcessMove(onfoot.Movement.ReadValue<Vector2>());
    }

    private void LateUpdate()
    {
        cam.ProcessLook(onfoot.Look.ReadValue<Vector2>());
    }

}
