using System;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput; // Variable to store horizontal input from the player
    public float speed = 10.0f; // Variable to control the speed of the player movement
    public float xRange = 11.0f; // Variable to define the horizontal boundaries for the player's movement

    public GameObject projectilePrefab; //  Variable to hold the projectile prefab that will be instantiated when the player shoots

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        //below i check if the space key is pressed and if it is, i instantiate a projectile from the projectile prefab at the player's current position and with the same rotation as the projectile prefab. I also check if the projectilePrefab variable is assigned to avoid potential errors.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // here i used Instantiate to create a new instance of the projectilePrefab at the player's current position and with the same rotation as the projectilePrefab. This allows the player to shoot projectiles when the space key is pressed.
            if (projectilePrefab != null)
            {
                Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            }
            else
            {
                Debug.LogWarning("PlayerController: projectilePrefab is not assigned.");
            }
        }

        //below i check if the player's position has exceeded the defined horizontal boundaries (xRange) and if it has, i set the player's position to the boundary value to prevent it from moving outside the allowed area. I also get the horizontal input from the player using Input.GetAxis("Horizontal") and use it to move the player left or right based on the input and the defined speed.
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        // Check if the player's position has exceeded the right boundary and if so, set it to the boundary value
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        // Get the horizontal input from the player (e.g., arrow keys or A/D keys)
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
