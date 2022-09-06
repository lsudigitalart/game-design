// Description:
// Restarts the level when a specified key is pressed.
//
// Prereqs:
// 1. Attach script the Main Camera.
// 2. Specify the key for restart in the inspector.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelOnButton : MonoBehaviour
{
    [SerializeField]
    KeyCode keyRestart;

    void Update()
    {
        if (Input.GetKey(keyRestart))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}