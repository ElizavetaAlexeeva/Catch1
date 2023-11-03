using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFall : MonoBehaviour
{

    public AudioSource fall;
    public AudioSource rockDestroy;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == ("SlimWoman"))
        {
            fall.Play();

        }
        if (collision.collider.tag == ("rock"))
            rockDestroy.Play();
        }
    }

