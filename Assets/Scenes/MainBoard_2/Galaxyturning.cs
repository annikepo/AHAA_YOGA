
using UnityEngine;

public class GalaxyRotation : MonoBehaviour
{
    public float rotationSpeed = 0.1f; // Adjust the rotation speed as desired

    private void Update()
    {
        // Rotate the galaxy object around its vertical axis
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed, Space.Self);
    }
}
