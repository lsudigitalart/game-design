// Description:
// Allow a Game Object like a playable avatar to be controlled using the keyboard.
//
// Prereqs:
// 1. Attach this script to the Game Object you want to control. 
// 2. Add the Rigid Body component to the same Game Object.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{

    [SerializeField]
    Vector3 vector1;

    [SerializeField]
    KeyCode keyPositive1;

    [SerializeField]
    KeyCode keyNegative1;

    [SerializeField]
    Vector3 vector2;

    [SerializeField]
    KeyCode keyPositive2;

    [SerializeField]
    KeyCode keyNegative2;


    void FixedUpdate() 
    {
        if (Input.GetKey(keyPositive1))
        {
            GetComponent<Rigidbody>().velocity += vector1;
        }

        if (Input.GetKey(keyNegative1))
        {
            GetComponent<Rigidbody>().velocity -= vector1;
        }

        if (Input.GetKey(keyPositive2))
        {
            GetComponent<Rigidbody>().velocity += vector2;
        }

        if (Input.GetKey(keyNegative2))
        {
            GetComponent<Rigidbody>().velocity -= vector2;
        }
    }
}
