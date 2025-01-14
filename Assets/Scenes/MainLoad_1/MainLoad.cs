using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // The name of the scene you want to load
    private string sceneToLoad = "MainBoard";

    void Start()
    {
        // Start the coroutine to change the scene after 5 seconds
        StartCoroutine(ChangeSceneAfterDelay(5f));
    }

    private IEnumerator ChangeSceneAfterDelay(float delay)
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);

        // Load the specified scene
        SceneManager.LoadScene(sceneToLoad);
    }
}

