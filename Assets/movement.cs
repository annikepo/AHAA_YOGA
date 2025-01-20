using UnityEngine;

public class DelayedPolysurfaceMovement : MonoBehaviour
{
    public GameObject polysurface1; // First object to move
    public GameObject polysurface2; // Second object to move
    public GameObject polysurface3; // Third object to move
    public GameObject polysurface4; // Fourth object to move

    public Vector3 direction = new Vector3(0, 0, 1); // Direction of movement (z-axis)
    public float speed = 5f;                         // Speed of movement
    public float delay = 5f;                         // Delay between movements

    private float timer = 0f;                        // Timer to track movement
    private bool movePolysurface2 = false;
    private bool movePolysurface3 = false;
    private bool movePolysurface4 = false;

    void Update()
    {
        timer += Time.deltaTime;

        // Move polysurface1 immediately
        if (polysurface1 != null)
        {
            polysurface1.transform.position += direction * speed * Time.deltaTime;
        }

        // Start moving polysurface2 after 5 seconds
        if (timer >= delay && !movePolysurface2)
        {
            movePolysurface2 = true;
        }
        if (movePolysurface2 && polysurface2 != null)
        {
            polysurface2.transform.position += direction * speed * Time.deltaTime;
        }

        // Start moving polysurface3 after 10 seconds
        if (timer >= delay * 2 && !movePolysurface3)
        {
            movePolysurface3 = true;
        }
        if (movePolysurface3 && polysurface3 != null)
        {
            polysurface3.transform.position += direction * speed * Time.deltaTime;
        }

        // Start moving polysurface4 after 15 seconds
        if (timer >= delay * 3 && !movePolysurface4)
        {
            movePolysurface4 = true;
        }
        if (movePolysurface4 && polysurface4 != null)
        {
            polysurface4.transform.position += direction * speed * Time.deltaTime;
        }
    }
}
