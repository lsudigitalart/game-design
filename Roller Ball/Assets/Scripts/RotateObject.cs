// Description: Change rotatation of a Game Object over time. Using deltaTime so animation appears smooth.
//
// Prereqs:
// 1. Attach to Game Object you want to scale.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public Vector3 rotateChange;

    void Update()
    {
        transform.Rotate(rotateChange * Time.deltaTime);
    }
}
