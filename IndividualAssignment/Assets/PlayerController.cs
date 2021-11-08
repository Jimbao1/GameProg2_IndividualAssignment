using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float playerSpeed = 5.0f;
    private float horizontalInput;
    private float verticalInput;

    // test
    public float jumpSpeed = 7500f;

    Rigidbody rb;
    bool canJump;



    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        Move();
        Jump();
    }

    private void Move()
    {
        // Move forward
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed * verticalInput);

        //// Move sideways 
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * playerSpeed * horizontalInput);

        // Rotate
        //transform.Rotate(Vector3.up, rotationSpeed * horizontalInput * Time.deltaTime);

    }

    private void Jump()
    {
        if (Input.GetKey(KeyCode.Space) & canJump)
        {
            rb.AddForce(0f, jumpSpeed * Time.deltaTime, 0f);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Floor")
        {
            canJump = true;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Floor")
        {
            canJump = false;
        }
    }


}
