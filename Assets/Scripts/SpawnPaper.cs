using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPaper : MonoBehaviour
{
    [SerializeField]
    private AudioClip clip;

    [SerializeField]
    private GameObject paperToSpawn;

    [SerializeField]
    private GameObject position;

    public void spawn()
    {
        StartCoroutine(ExecuteAfterTime(clip.length));
    }

    public IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        Instantiate(paperToSpawn, position.transform.position, position.transform.rotation);
    }
}
 