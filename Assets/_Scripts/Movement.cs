using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");

        // Normalize the movement vector to avoid faster diagonal movement
        Vector3 move = new Vector3(moveX, 0f, moveZ).normalized * (moveSpeed * Time.deltaTime);

        // Apply the movement to the player
        transform.Translate(move);
    }
}
