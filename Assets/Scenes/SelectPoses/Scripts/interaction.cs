using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class PoseGrabDropAndSceneTransition : MonoBehaviour
{
    private bool isPoseInside = false;

    void OnTriggerEnter(Collider other)
    {
        XRGrabInteractable grabInteractable = other.GetComponent<XRGrabInteractable>();

        // Check if the object entering the trigger is a Pose and is not being held
        if (!other.CompareTag("Pose") || grabInteractable == null || grabInteractable.isSelected)
        {
            return;
        }

        Debug.Log(other.name + " entered the Box Base_collider");
        isPoseInside = true;
    }

    void Update()
    {
        if (isPoseInside)
        {
            Debug.Log("Loading next scene...");
            // Move to the next scene
            SceneManager.LoadScene("NextSceneName"); // Replace "NextSceneName" with the actual scene name
        }
    }
}



