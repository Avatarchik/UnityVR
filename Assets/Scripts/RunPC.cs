using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunPC : MonoBehaviour
{
    public GameObject canvas;
    private bool Isvisible = false;

    public AudioSource source;
    [SerializeField]
    private AudioClip StartSound;
    [SerializeField]
    private AudioClip EndSound;

    public void TogglePC()
    {
        if (!Isvisible)
        {
            StartPC();
        }
        else
        {
            ShutDownPC();
        }
    }

    private void StartPC()
    {
        canvas.SetActive(true);
        source.clip = StartSound;
        source.Play();
        Isvisible = true;
    }

    private void ShutDownPC()
    {
        canvas.SetActive(false);
        source.clip = EndSound;
        source.Play();
        Isvisible = false;
    }
}