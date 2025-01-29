using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 5f; // ������ƶ��ٶ�
    private Rigidbody rb; // ����ĸ������

    void Start()
    {
        // Get the RigidBody
        rb = GetComponent<Rigidbody>();
    }

    // Directions
    private float lastHorizontal = 0;
    private float lastVertical = 0;

    // The ability of Jumping
    public float jumpForce = 1000f;

    // on the ground?
    private bool isGrounded = true; 



    void Update()
    {
        // invoke Input Detector
        InputDetector();

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Only the Input value changes,the value changes
        if (moveHorizontal != lastHorizontal || moveVertical != lastVertical)
        {
            Debug.Log($"User Input - Horizontal: {moveHorizontal}, Vertical: {moveVertical}");
            lastHorizontal = moveHorizontal;
            lastVertical = moveVertical;
        }


        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // For Bonus 
        // Detect input
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Debug.Log("Start");

            rb.AddForce(Vector3.up * jumpForce);
            //isGrounded = false; 
        }
        //Debug.Log(isGrounded);

        rb.AddForce(movement * speed);
    }




    void OnCollisionEnter(Collision collision)
    {
        //  isGrounded is true
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            Debug.Log("Ball has landed on the ground.");
            Vector3 velocity = rb.linearVelocity; // 
            Vector3 newVelocity = new Vector3(velocity.x, 0.0f, velocity.z); // 
            rb.linearVelocity = newVelocity; // 

        }
    }

    void OnCollisionExit(Collision collision)
    {
        //  isGrounded is false
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
            Debug.Log("Ball has left the ground.");
        }
    }

    public void InputDetector() {
        
        // Detect Input
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Input detected: W key");
            Debug.Log(Vector2.up);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Input detected: A key");
            Debug.Log(Vector2.left);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Input detected: S key");
            Debug.Log(Vector2.down);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Input detected: D key");
            Debug.Log(Vector2.right);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Input detected: Space key");
        }
    }
}
