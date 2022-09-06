// Description:
// Plays a sound when 2 objects collide.
//
// Prereqs:
// 1. Attached to a Game Object that also has the following a Rigid Body component and Audio Source component.
// 2. There's a Game Object that is tagged something particular, i.e. "Lava".
// 3. In the inspector you specify this tag.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioOnCollision : MonoBehaviour
{
	AudioSource source;

	[SerializeField]
	string strTag;

	void Start()
	{
		source = GetComponent<AudioSource>();
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.tag == strTag && !source.isPlaying) // Using isPlaying here so sound doesn't keep restarting on mulitple collisions.
        {
			source.Play();
		}
	}
}