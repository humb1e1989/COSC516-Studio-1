using UnityEngine;

public class Test : MonoBehaviour
{
    public float speed = 10f; // 球体的移动速度
    public float jumpForce = 300f; // 跳跃力度
    private Rigidbody rb; // 球体的刚体组件
    private bool isGrounded; // 检测是否在地面上

    void Start()
    {
        // 获取刚体组件
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // 获取玩家输入的移动方向
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // 推动球体
        rb.AddForce(movement * speed);

        // 检测跳跃输入
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce);
            //isGrounded = false; // 防止空中重复跳跃
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // 当接触到地面时，设置 isGrounded 为 true
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            Debug.Log("Ball has landed on the ground.");
        }
    }

    void OnCollisionExit(Collision collision)
    {
        // 当球体离开地面时，设置 isGrounded 为 false
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
            Debug.Log("Ball has left the ground.");
        }
    }
}
