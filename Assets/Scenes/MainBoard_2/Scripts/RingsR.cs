using UnityEngine;

public class RotateRing : MonoBehaviour
{
    public float rotationSpeed = 10f; // Rotation speed of the object
    public float movementSpeed = 5f; // Movement speed of the object
    public float movementRange = 2f; // Range of movement of the object
    public float radius = 1f; // Radius of the object

    private float angle = 0f; // Angle of the object

    private void Update()
    {
        // Calculate the angle of the object
        angle += rotationSpeed * Time.deltaTime;

        // Calculate the position of the object
        float x = Mathf.Cos(angle) * radius;
        float z = Mathf.Sin(angle) * radius;

        // Ensure the object stays within the movement range
        x = Mathf.Clamp(x, -movementRange, movementRange);
        z = Mathf.Clamp(z, -movementRange, movementRange);

        // Set the position of the object
        transform.position = new Vector3(x, 0f, z);
    }
}