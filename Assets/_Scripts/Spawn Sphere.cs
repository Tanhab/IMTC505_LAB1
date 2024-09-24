using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSphere : MonoBehaviour
{
    public GameObject sphere;  // Reference to the ball above obstacle wall

    void OnCollisionEnter(Collision collision)
    {
        // Enable the sphere when a collision occurs
        if (sphere != null)
        {
            // Make the sphere visible
            sphere.SetActive(true);

        }
    }
}
