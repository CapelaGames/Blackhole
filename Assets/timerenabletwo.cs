using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class things
{
    public GameObject enable;
    public float time;
}

public class timerenabletwo : MonoBehaviour
{

    public List<things> enable;

    private void OnEnable()
    {
        StartDoing();
    }

    private void StartDoing()
    {
        foreach (things thing in enable)
        {
            StartCoroutine(enabledisable(thing));
        }
    }


    public IEnumerator enabledisable(things thing)
    {
        yield return new WaitForSeconds(thing.time);
        
        thing.enable.SetActive(true);
    }
}
