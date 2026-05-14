using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playervelocity;
    private bool isGrounded;
    public float speed = 10f;
    public float gravity = -9.8f;
    public float jumpHeight = 3f;

    public bool sprinting = false;

    public bool lerpCrouch;
    public bool crouching;

    public float crouchTimer;

    [SerializeField] GameObject pauseMenu;

    private bool canPause;

    private bool canMove;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        canPause = true;
    }

    // receives the inputs for our InputManger.cs and apply them to our character controller

    private void Update()
    {
        isGrounded = controller.isGrounded;
        if (lerpCrouch)
        {
            crouchTimer += Time.deltaTime;
            float p = crouchTimer / 1;
            p *= p;

            if (crouching)
            {
                controller.height = Mathf.Lerp(controller.height, 1, p);
            }

            else
            {
                controller.height = Mathf.Lerp(controller.height, 2, p);
            }

            if (p > 1)
            {
                lerpCrouch = false;
                crouchTimer = 0f;
            }

        }
    }

    public void ProcessMove(Vector2 input)
    {
        if ( (canMove == true))
        {
            Vector3 moveDirection = Vector3.zero;
            moveDirection.x = input.x;
            moveDirection.z = input.y;
            controller.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);
            playervelocity.y += gravity * Time.deltaTime;

            if (isGrounded && playervelocity.y < 0)
            {
                playervelocity.y = -2f;
            }

            controller.Move(playervelocity * Time.deltaTime);

        }

        if (canMove == false)
        {
            Debug.Log("Player Frozen");
        }

    }

    public void Jump()
    {
        if (canMove == true)
        {
            if (isGrounded)
            {
                playervelocity.y = Mathf.Sqrt(jumpHeight * -3.0f * gravity);
            }
        }

        if (canMove == false)
        {
            Debug.Log("Player Frozen");
        }

    }

    public void Sprint()
    {
        sprinting = !sprinting;
        if (sprinting)
        {
            speed = 14;
        }
        else
        {
            speed = 10;
        }
    }

    public void Crouch()
    {
        crouching =  !crouching;
        crouchTimer = 0f;
        lerpCrouch = true;
    }

    public void Pause()
    {
        if (canPause == true)
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
        }

        if (canPause == false)
        {
            Debug.Log("Can't Pause!");
        }

    }

    public void MoveDeactiavte()
    {
        canMove = false;
    }

    public void MoveActiavte()
    {
        canMove = true;
    }

    public void PauseDeactivate()
    { 
        canPause = false;
    }

    public void PauseActivate()
    {
        canPause = true;
    }

}
