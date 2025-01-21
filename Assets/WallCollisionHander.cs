
using UnityEngine;

public class WallCollisionHandler : MonoBehaviour
{
    // This method is called when the GameObject collides with another GameObject
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object has the tag "Wall"
        if (collision.gameObject.CompareTag("Wall"))
        {
            // Print a message to the console
            Debug.Log("Wall has hit the target!");
            // You can add additional logic here, such as triggering an event or effect
        }
    }
}
