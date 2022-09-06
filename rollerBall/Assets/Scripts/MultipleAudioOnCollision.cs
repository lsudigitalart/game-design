// Description:
// Plays a "win" sound when 2 objects collide or a "lose" sound when 2 other objects collide.
//
// Prereqs:
// 1. Attached to a Game Object that also has a Rigid Body component.
// 2. There are 2 Game Objects that are tagged something particular, i.e. "Lava" and "Goal".
// 3. In the inspector you specify these tags.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleAudioOnCollision : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip winClip;
    public AudioClip loseClip;

    [SerializeField]
    string winTag;

    [SerializeField]
    string loseTag;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == winTag)
        {
            audioSource.PlayOneShot(winClip);
        }

        if (collision.collider.tag == loseTag)
        {
            audioSource.PlayOneShot(loseClip);
        }
    }
}