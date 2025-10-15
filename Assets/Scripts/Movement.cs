// Import libraries and modules
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Movement class
public class Movement : MonoBehaviour
{
    // Variable declaration and initialization
    [SerializeField]
    private float movementSpeed = 5f;

    [SerializeField]
    private float rotateSpeed = 200f;

    [SerializeField]
    private float jumpForce = 5f;

    private Rigidbody rb;
    private bool explorerIsOnTheGround = true;

    // Start function is called once at the start
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Returns an error log message if the Rigidbody has not been set
        if (rb == null)
        {
            Debug.LogError("Rigidbody component is missing!");
        }
    }

    // Update function
    void Update()
    {
        float movement = Input.GetAxis("Vertical");
        float turn = Input.GetAxis("Horizontal");

        // Movement and rotation keyboard input
        transform.Translate(Vector3.forward * movement * movementSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * turn * rotateSpeed * Time.deltaTime);

        // Jump trigger and response
        if (Input.GetButtonDown("Jump") && explorerIsOnTheGround)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

            // Prevent mid-air jumps
            explorerIsOnTheGround = false;
            Debug.Log("Jump triggered");
        }

        // Reset position and rotation with 'R' key
        if (Input.GetKeyDown(KeyCode.R))
        {
            // Reset position if needed
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            // Reset rotation
            transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);
        }
    }

    // OnCollisionEnter function ensures that the object is in contact with the "Ground"
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            // Returns a log message that the object has landed back onto the "Ground"
            Debug.Log("Landed on the ground");
            explorerIsOnTheGround = true;
        }
    }

    // OnCollisionStay function verifies that the object is on the "Ground"
    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            // If the object is back on the ground then the boolean is set to true to indicate the the object is indeed on the "Ground"
            explorerIsOnTheGround = true;
        }
    }

    // OnCollisionExit function verifies that the object has left the "Ground"
    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            // If the object has left the "Ground" the boolean is set to false to indicate that the object is no longer in contact with the "Ground"
            explorerIsOnTheGround = false;
        }
    }
}
