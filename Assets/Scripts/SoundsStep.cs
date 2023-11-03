using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsStep : MonoBehaviour
{
    public AudioClip step;
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void StepSoundPlay()
    {
        audioSource.PlayOneShot(step);
    }
    

}
