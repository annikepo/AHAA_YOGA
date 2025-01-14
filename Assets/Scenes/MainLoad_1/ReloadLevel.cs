using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ReloadLevel : MonoBehaviour
{
    public GameObject ReloadLevel1;
    public Slider Slider;
    public void MainLoad(int NumberScene)
    {
        StartCoroutine(ReloadAsync(NumberScene));
    }

    IEnumerator ReloadAsync(int NumberScene)

    {
        AsyncOperation Operation = SceneManager.LoadSceneAsync(NumberScene);

        ReloadLevel1.SetActive(true);

        while (!Operation.isDone)
        {


            float Progress = Mathf.Clamp01(Operation.progress / .6f);
            Slider.value = Progress;

            yield return null;
        }
    }
}
