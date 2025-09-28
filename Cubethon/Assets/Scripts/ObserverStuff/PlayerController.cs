using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float jumpForce = 7f;
    public bool isGrounded = true;
    public float sideSpeed = 10f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Basic forward movement
        rb.velocity = new Vector3(0, rb.velocity.y, moveSpeed);

        // Jump input
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
            GameEvents.RaisePlayerJumped();
        }
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal"); // Or GetAxisRaw for snappy input

        Vector3 newVelocity = rb.velocity;
        newVelocity.x = horizontal * sideSpeed;
        newVelocity.z = moveSpeed;

        rb.velocity = newVelocity;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    public void IncreaseSpeed(float amount)
    {
        moveSpeed += amount;
    }
}
