using UnityEngine;

public class InputManager : MonoBehaviour
{

    private PlayerInput playerInput;
    private PlayerInput.OnFootActions onfoot;

    private void Awake()
    {
        playerInput = new PlayerInput();
        onfoot = playerInput.OnFoot;
    }

    private void OnEnable()
    {
        onfoot.Enable();
    }

    private void OnDisable()
    {
        onfoot.Disable();
    }

}
