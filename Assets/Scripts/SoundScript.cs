using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public AudioClip triggerSound;
    public AudioSource source;
    public void OnTriggerEnter(Collider other)
    {
        source.PlayOneShot(triggerSound);
    }
}
