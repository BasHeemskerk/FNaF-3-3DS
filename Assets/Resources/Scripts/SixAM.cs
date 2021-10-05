using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SixAM : MonoBehaviour {

    public float WaitTimeCheer;
    public float WaitTimeScene;
    public AudioSource ChildrenCheer;

    void Start ()
    {
        StartCoroutine(Wait());
	}
	

	IEnumerator Wait ()
    {
        yield return new WaitForSeconds(WaitTimeCheer);
        ChildrenCheer.Play();
        StartCoroutine(WaitForLoadNextScene());
	}

    IEnumerator WaitForLoadNextScene()
    {
        yield return new WaitForSeconds(WaitTimeScene);
        SceneManager.LoadScene("NextNight");
    }
}
