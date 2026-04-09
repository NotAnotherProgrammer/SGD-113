using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other) // Method that is called when the collider attached to this GameObject enters a trigger collider. It takes a Collider object as a parameter, which represents the other collider that was entered.
    {
        Destroy(gameObject); // Destroy the current GameObject (the one this script is attached to) when it collides with another object. This is typically used to remove the projectile from the scene when it hits an enemy or another object.
        Destroy(other.gameObject); // Destroy the other GameObject that was collided with. This is typically used to remove the enemy or target from the scene when it is hit by the projectile.
    }
}
