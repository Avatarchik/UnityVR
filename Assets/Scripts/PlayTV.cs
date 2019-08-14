using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayTV : MonoBehaviour
{
    public GameObject canvas;
    private bool Isvisible = false;

    public void ToggleVisibility()
    {
        Isvisible = !Isvisible;
        canvas.SetActive(Isvisible);
    }
}
