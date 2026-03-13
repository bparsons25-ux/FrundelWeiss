using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playervelocity;
    public float speed = 5f;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // receives the inputs for our InputManger.cs and apply them to our character controller

    public void ProcessMove(Vector2 input)
    {

    }

}
