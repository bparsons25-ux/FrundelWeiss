using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playervelocity;
    private bool isGrounded;
    public float speed = 5f;
    public float gravity = -9.8f;
    public float jumpHeight = 3f;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // receives the inputs for our InputManger.cs and apply them to our character controller

    private void Update()
    {
        isGrounded = controller.isGrounded;
    }

    public void ProcessMove(Vector2 input)
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
        Debug.Log(playervelocity.y);
    }

    public void Jump()
    {
        if (isGrounded)
        {
            playervelocity.y = Mathf.Sqrt(jumpHeight * -3.0f * gravity);
        }
    }
}
