using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f; //here i set the top boundary for the objects to be destroyed

    private float lowerBound = -10.0f; //here i set the lower boundary for the objects to be destroyed and log a game over message

    void Update()
    {
        // Check if the object has exceeded the top boundary
        if (transform.position.z > topBound)
        {
            // Destroy the object to prevent it from continuing indefinitely
            Destroy(gameObject);
        }
        // Check if the object has fallen below the lower boundary
        else if (transform.position.z < lowerBound)
        {
            // Destroy the object and log game over message
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }
    }
}


