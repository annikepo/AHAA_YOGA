using UnityEngine;

public class PlayerCollisionHandler : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // Check if the player collides with a wall
        if (other.CompareTag("Wall"))
        {
            Debug.Log("Collision detected! You missed the hole!");

            // Handle collision (e.g., reset the player, decrease health, etc.)
            HandleCollision();
        }
    }

    private void HandleCollision()
    {
        // Add your logic here (e.g., respawn, reduce health, or play an effect)
        Debug.Log("Player collided with a wall!");
    }
}