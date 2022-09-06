// Description: Change position of a Game Object over time. Using deltaTime so animation appears smooth.
//
// Prereqs:
// 1. Attach to Game Object you want to scale.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateObject : MonoBehaviour
{
    public Vector3 positionChange;

    void Update()
    {
        transform.position += (positionChange * Time.deltaTime);
    }
}