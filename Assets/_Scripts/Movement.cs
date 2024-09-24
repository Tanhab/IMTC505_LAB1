using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f; // control speed of the robot
    

    void Update()
    {
        // Get -1 to 1 depending on left or right movement
        float moveX = Input.GetAxisRaw("Horizontal");
        // Get -1 to 1 depending on forward or backward movement
        float moveZ = Input.GetAxisRaw("Vertical");

        // Create a new vector position with the directions added
        // Normalize the movement vector to avoid faster diagonal movement
        // Time.DeltaTime for frame wise update
        Vector3 move = new Vector3(moveX, 0f, moveZ).normalized * (moveSpeed * Time.deltaTime);

        // Apply the movement to the robot
        transform.Translate(move);
    }
}
