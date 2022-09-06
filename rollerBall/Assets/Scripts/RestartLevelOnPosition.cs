// Description:
// Restarts the level when a Game Object's position in the Y is less than specified.
//
// Prereqs:
// 1. Attach script to a Game Object that you want to be trigger the restart.
// 2. Specify the minimum values for restart in the inspector.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelOnPosition : MonoBehaviour
{
    [SerializeField]
    Vector3 minimumObjectPosition;

    void Update()
    {
        if (transform.position.y < minimumObjectPosition.y)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}