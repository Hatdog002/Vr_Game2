using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float movementSpeed = 3f; // Adjust this to control movement speed


    private void Update()
    {
        // Move the enemy forward (in the positive z-axis direction)
        Vector3 movement = transform.forward * movementSpeed * Time.deltaTime;
        transform.position += movement;
    }
}
