// Description: Change scale of a Game Object over time. Using deltaTime so animation appears smooth.
//
// Prereqs:
// 1. Attach to Game Object you want to scale.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleObject : MonoBehaviour
{
	public Vector3 scaleChange;

	void Update()
	{
		transform.localScale += (scaleChange * Time.deltaTime);

	}
}