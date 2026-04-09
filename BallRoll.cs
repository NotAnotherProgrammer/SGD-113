using UnityEngine;

public class BallControllerAndShooter : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 10f; // Speed at which the ball moves
    private Rigidbody rb; // Reference to the Rigidbody component for physics-based movement

    [Header("Shooting")]
    public GameObject projectilePrefab; // Prefab of the projectile to be instantiated when shooting
    public Transform firePoint; // Transform representing the position and rotation from which the projectile will be fired
    public float shootForce = 500f; //  Force applied to the projectile when shooting

    // Called when the script instance is being loaded. Initializes the Rigidbody component.
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Get the Rigidbody component attached to the ball for movement
    }

    // Called every fixed framerate frame. Handles horizontal and vertical input to move the ball by applying force.
    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal"); // Get horizontal input (A/D or Left/Right arrow keys)
        float moveZ = Input.GetAxis("Vertical"); // Get vertical input (W/S or Up/Down arrow keys)

        Vector3 movement = new Vector3(moveX, 0f, moveZ); // Create a movement vector based on input
        rb.AddForce(movement * moveSpeed); // Apply force to the Rigidbody to move the ball in the desired direction
    }

    // Called every frame. Checks if the space key is pressed to trigger shooting.
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Check if the space key is pressed
        {
            ShootProjectile(); // Call the method to shoot a projectile when the space key is pressed
        }
    }

    // Instantiates a projectile prefab at the fire point position and rotation, then applies forward force to it.
    void ShootProjectile()
    {
        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation); // Instantiate the projectile at the fire point's position and rotation

        Rigidbody projectileRb = projectile.GetComponent<Rigidbody>(); // Get the Rigidbody component of the instantiated projectile to apply force

        if (projectileRb != null) // Check if the projectile has a Rigidbody component before applying force
        {
            projectileRb.AddForce(firePoint.forward * shootForce); // Apply force to the projectile in the forward direction of the fire point, multiplied by the shoot force
        }
        Destroy(projectile, 3f); // Destroy the projectile after 3 seconds to prevent it from existing indefinitely in the scene
    }
}