// Import libraries and modules
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Mouselook class
public class MouseLook : MonoBehaviour
{
    // Variable declarations and initializations
    public float mouseSensitivity = 100f;
    public Transform cylinderBody;

    private float xRotation = 0f;

    // Start function is called once at the start
    void Start()
    {
        // Lock the cursor to the game window
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update function
    void Update()
    {
        // Get mouse input and position
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Rotate the cylinder horizontally
        cylinderBody.Rotate(Vector3.up * mouseX);

        // Rotate the camera vertically
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}
