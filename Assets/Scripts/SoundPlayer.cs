using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    public AudioSource source;
    public AudioClip sound;

   public void PlaySound()
    {
        source.clip = sound;
        source.Play();
    }
}
