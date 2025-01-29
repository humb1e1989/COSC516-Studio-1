using UnityEngine;

public class Test : MonoBehaviour
{
    public float speed = 10f; // ������ƶ��ٶ�
    public float jumpForce = 300f; // ��Ծ����
    private Rigidbody rb; // ����ĸ������
    private bool isGrounded; // ����Ƿ��ڵ�����

    void Start()
    {
        // ��ȡ�������
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // ��ȡ���������ƶ�����
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // �ƶ�����
        rb.AddForce(movement * speed);

        // �����Ծ����
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce);
            //isGrounded = false; // ��ֹ�����ظ���Ծ
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // ���Ӵ�������ʱ������ isGrounded Ϊ true
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            Debug.Log("Ball has landed on the ground.");
        }
    }

    void OnCollisionExit(Collision collision)
    {
        // �������뿪����ʱ������ isGrounded Ϊ false
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
            Debug.Log("Ball has left the ground.");
        }
    }
}
