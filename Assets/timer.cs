using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    public GameObject enable;

	// Use this for initialization
	void Start ()
    {
        StartCoroutine(enabledisable());	
        if(enable == null)
        {
            Debug.LogError("enable not attached");
        }
	}
	


    public IEnumerator enabledisable()
    {
         yield return new WaitForSeconds(10f);

        gameObject.SetActive(false);
        enable.SetActive(true);
    }
    
}
