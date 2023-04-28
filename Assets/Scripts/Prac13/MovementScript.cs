using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public CharacterController characterController;

    public float speed = 12f;

    public float gravity = 9.8f;

    public float maxFallSpeed = 53f;

    public Vector3 velocity;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    public bool isGrounded;

    public float jumpSpeed = 12f;

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        characterController.Move(move * speed * Time.deltaTime);

        velocity.y -= gravity * Time.deltaTime;
        if (velocity.y < -maxFallSpeed) velocity.y = -maxFallSpeed;
        characterController.Move((velocity * Time.deltaTime) / 2);

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = jumpSpeed;
        }
    }
}
