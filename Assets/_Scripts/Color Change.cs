using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
   

    private void OnCollisionEnter(Collision collision)
    {
        // change the material to red on collision
        GetComponent<Renderer>().material.color = Color.red;
    }
}
