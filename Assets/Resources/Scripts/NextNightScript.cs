using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextNightScript : MonoBehaviour {

    public Text NextNightTextGreen;
    public Text NextNightTextRed;

    public GameObject GreenText;
    public GameObject RedText;

    public float WichNight;

    public float WaitBeforeChanging;

	void Start ()
    {
        if (PlayerPrefs.HasKey("WichNight")) WichNight = PlayerPrefs.GetFloat("WichNight", WichNight);

        if (WichNight == 1)
        {
            GreenText.SetActive(true);
        }

        if (WichNight > 1)
        {
            RedText.SetActive(true);
        }

        SetText();
	}

	void SetText ()
    {
        NextNightTextGreen.text = "Night " + WichNight.ToString();
        NextNightTextRed.text = "Night " + WichNight.ToString();

        StartCoroutine(wait());
	}

    IEnumerator wait()
    {
        yield return new WaitForSeconds(WaitBeforeChanging);
        SceneManager.LoadScene("Game");
    }
}
