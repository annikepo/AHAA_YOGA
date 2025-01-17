using UnityEngine;

public class SkyboxChanger : MonoBehaviour
{
    // Assign your skybox material in the Inspector
    public Material skyboxMaterial;

    // Speed of rotation
    public float rotationSpeed = 1.0f;

    void Start()
    {
        // Check if the skybox material is assigned
        if (skyboxMaterial != null)
        {
            // Set the skybox material
            RenderSettings.skybox = skyboxMaterial;
        }
        else
        {
            Debug.LogWarning("Skybox material is not assigned!");
        }
    }

    void Update()
    {
        // Rotate the skybox
        if (skyboxMaterial != null)
        {
            // Calculate the rotation amount
            float rotationAmount = rotationSpeed * Time.deltaTime;

            // Rotate the skybox around the Y-axis
            skyboxMaterial.SetFloat("_Rotation", skyboxMaterial.GetFloat("_Rotation") + rotationAmount);
        }
    }
}