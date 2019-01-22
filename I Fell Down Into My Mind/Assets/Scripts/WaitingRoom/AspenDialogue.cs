using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AspenDialogue : MonoBehaviour {

    public AudioClip teleportInstructions;
    AudioSource audioSource;
    public GameObject aspen;

    // Update is called once per frame
    void Update () {
        if (aspen.transform.position.y >= .25f)
        {
            audioSource.clip = teleportInstructions;
            audioSource.Play();
        }
    }
}
