using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
   

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
}
