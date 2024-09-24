using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSphere : MonoBehaviour
{
    public GameObject sphere;  // Reference to the sphere above the object

    void OnCollisionEnter(Collision collision)
    {
        // Enable the sphere when a collision occurs
        if (sphere != null)
        {
            // Make the sphere visible
            sphere.SetActive(true);

            // Add a Rigidbody component to the sphere if it doesn't already have one
            Rigidbody rb = sphere.GetComponent<Rigidbody>();
            if (rb == null)
            {
                rb = sphere.AddComponent<Rigidbody>();
            }

            // Ensure gravity is enabled
            rb.useGravity = true;
        }
    }
}
