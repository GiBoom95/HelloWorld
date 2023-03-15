using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 5f;
    public float groundDistance = 0.2f;
    public LayerMask groundLayer;
    public float gravity = 9.81f;

    private bool isGrounded = true;
    // Start is called before the first frame update
    void Start()
    {
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

        if (!isGrounded && Physics.Raycast(transform.position, Vector3.down, groundDistance, groundLayer))
        {
            isGrounded = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

        if (!isGrounded && Physics.Raycast(transform.position, Vector3.down, groundDistance, groundLayer))
        {
            isGrounded = true;
        }
    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.down * gravity, ForceMode.Acceleration);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == groundLayer)
        {
            isGrounded = true;
        }
    }
}
