using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private bool shouldRotate = false; // Toggle for rotation after hitting robot

 
    void Update()
    {
        if (shouldRotate)
        {
            transform.Rotate(Vector3.up * 100f * Time.deltaTime); // Rotate on Y-axis( vector.up)
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        shouldRotate = true; // start rotaing
    }
}
