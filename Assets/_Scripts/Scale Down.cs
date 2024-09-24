using UnityEngine;
using TMPro;  // Required for TextMeshPro

public class ScaleDown : MonoBehaviour
{
    // make it half - 0.5
    public float scaleFactor = 0.5f;

    private bool isScaledOnce = false; // I want to shorten it once

    void OnCollisionEnter(Collision collision)
    {
        // Scale the main object to half only if its first time
        if (!isScaledOnce)
        {
            isScaledOnce = true;
            transform.localScale *= scaleFactor;
        }
        

        
    }
}


