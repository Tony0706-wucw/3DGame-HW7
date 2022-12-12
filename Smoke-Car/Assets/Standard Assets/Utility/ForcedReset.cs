using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;


public class ForcedReset : MonoBehaviour
{
    private void Update()
    {
        // if we have forced a reset ...
        if (CrossPlatformInputManager.GetButtonDown("ResetObject"))
        {
            //... reload the scene
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
        }
    }
}
