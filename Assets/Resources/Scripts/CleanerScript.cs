using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class CleanerScript : MonoBehaviour {

    public float CleanTimer = 60;

    public bool isNotGameScene = false;

	void Start ()
    {
        StartCoroutine(SceneCleanerTimer());
        UnloadScenes();
	}
	
    IEnumerator SceneCleanerTimer()
    {
        yield return new WaitForSeconds(CleanTimer);
        UnloadAssets();
        CollectGarbage();
    }

    void UnloadAssets()
    {
        Resources.UnloadUnusedAssets();
    }

    void CollectGarbage()
    {
        GC.Collect();
    }


    void UnloadScenes()
    {
        SceneManager.UnloadSceneAsync("Menu");
        SceneManager.UnloadSceneAsync("NewsPaper");
        SceneManager.UnloadSceneAsync("NextNight");
        SceneManager.UnloadSceneAsync("6AM");

        if (isNotGameScene)
        {
            SceneManager.UnloadSceneAsync("Game");
        }
    }
}
