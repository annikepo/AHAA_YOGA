using System.Collections;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Management;

public class XRManagerHelper : MonoBehaviour
{
    public void StopXR()
    {
        if (XRGeneralSettings.Instance.Manager.isInitializationComplete)
        {
            XRGeneralSettings.Instance.Manager.StopSubsystems();
            Debug.Log("XR Subsystems Stopped");
        }
    }

    public void DeinitializeXR()
    {
        if (XRGeneralSettings.Instance.Manager.isInitializationComplete)
        {
            XRGeneralSettings.Instance.Manager.DeinitializeLoader();
            Debug.Log("XR Loader Deinitialized");
        }
    }

    public void InitializeXR()
    {
        StartCoroutine(InitializeXRLoader());
    }

    private IEnumerator InitializeXRLoader()
    {
        if (XRGeneralSettings.Instance.Manager.activeLoader == null)
        {
            XRGeneralSettings.Instance.Manager.InitializeLoader();
            while (XRGeneralSettings.Instance.Manager.activeLoader == null)
            {
                yield return null;
            }
            XRGeneralSettings.Instance.Manager.StartSubsystems();
            Debug.Log("XR Loader Initialized and Subsystems Started");
        }
    }
}

