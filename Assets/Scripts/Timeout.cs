using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timeout : MonoBehaviour
{
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExecuteAfterTime(60));
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            canvas.SetActive(false);
        }
    }

    public IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        canvas.SetActive(false);
    }
}
