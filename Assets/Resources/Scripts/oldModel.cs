using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oldModel : MonoBehaviour {

    public GameObject[] DisableOnCanvas;
    public Image[] DisableImageOnlyOnCanvas;
    public GameObject[] DisableInScene;
    public Animator[] DisableAnimator;
    public AudioSource[] DisableAudio;

	public void isOldModel ()
    {
		foreach (GameObject disableOnCanvas in DisableOnCanvas)
        {
            disableOnCanvas.SetActive(false);
        }

        foreach (Image disableImageOnlyOnCanvas in DisableImageOnlyOnCanvas)
        {
            disableImageOnlyOnCanvas.enabled = false;
        }

        foreach (GameObject disableInScene in DisableInScene)
        {
            disableInScene.SetActive(false);
        }

        foreach (Animator disableAnimator in DisableAnimator)
        {
            disableAnimator.enabled = false;
        }

        foreach (AudioSource disableAudio in DisableAudio)
        {
            disableAudio.enabled = false;
        }
	}
}
