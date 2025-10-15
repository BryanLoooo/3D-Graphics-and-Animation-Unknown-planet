// Import libraries and modules
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// GravityToCentre class
public class GravityToCenter : MonoBehaviour
{
    // Variable declarations and intializations
    public Transform centerOfGravity;
    public float gravityStrength = 10f;

    // FixedUpdate function
    void FixedUpdate()
    {
        // Verify if the center of gravity is not null
        if (centerOfGravity != null)
        {
            Vector3 direction = (centerOfGravity.position - transform.position).normalized;
            Rigidbody rb = GetComponent<Rigidbody>();

            // Verify if the Rigidbody exists and is affected by the gravitational pull towards the planet
            if (rb != null)
            {
                rb.AddForce(direction * gravityStrength * rb.mass);
            }
        }
    }
}
