using UnityEngine;

public class InputManager : MonoBehaviour
{

    private PlayerInput playerInput;
    private PlayerInput.OnFootActions onfoot;

    private PlayerMovement movement;

    private void Awake()
    {
        playerInput = new PlayerInput();
        onfoot = playerInput.OnFoot;
        movement = GetComponent<PlayerMovement>();
        onfoot.Jump.performed += ctx => movement.Jump(); // ctx is callback context
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

}
