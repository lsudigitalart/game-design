// Description:
// Restarts the level on collision with another object with a specific tag.
//
// Prereqs:
// 1. Attach script to a Game Object that you want to be trigger the restart.
// 2. Tag a Game Object in the scene that you want to test for collision.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelOnCollision : MonoBehaviour
{
    [SerializeField]
    string strTag;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == strTag)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}