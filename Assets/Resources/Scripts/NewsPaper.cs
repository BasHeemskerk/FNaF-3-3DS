using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class NewsPaper : MonoBehaviour {

    public float WaitTime;
    public bool notNewsPaper;
	
	void Start()
    {
        StartCoroutine(wait());
    }

	IEnumerator wait ()
    {
        yield return new WaitForSeconds(WaitTime);
        GC.Collect();
        Resources.UnloadUnusedAssets();

        if (!notNewsPaper)
        {
            SceneManager.LoadScene("NextNight");
        }
        else
        {
            SceneManager.LoadScene("Title");
        }
	}
}
