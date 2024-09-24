using UnityEngine;
using TMPro;  // Required for TextMeshPro

public class ScaleDown : MonoBehaviour
{
    // make it half - 0.5
    public float scaleFactor = 0.5f;

    void OnCollisionEnter(Collision collision)
    {
        // Scale the main object to half
        transform.localScale *= scaleFactor;

        
    }
}


