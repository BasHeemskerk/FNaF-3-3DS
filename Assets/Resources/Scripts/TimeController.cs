using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeController : MonoBehaviour {

    public Text NightNumber;
    public Text TimeNumber;

    public float WichNight;
    public float Time = 1;

	
	void Start ()
    {
        if (PlayerPrefs.HasKey("WichNight")) WichNight = PlayerPrefs.GetFloat("WichNight", WichNight);

        if (WichNight <= 0)
        {
            WichNight = 1;
            PlayerPrefs.SetFloat("WichNight", WichNight);
            PlayerPrefs.Save();
            ShowTimeText();
        }

        StartCoroutine(TimeCounter());
        SetHour();
	}

    void ShowTimeText()
    {
        NightNumber.text = WichNight.ToString();
    }

    void SetHour()
    {
        if (Time == 1)
        {
            TimeNumber.text = "12";
        }

        if (Time == 2)
        {
            TimeNumber.text = "1";
        }

        if (Time == 3)
        {
            TimeNumber.text = "2";
        }

        if (Time == 4)
        {
            TimeNumber.text = "3";
        }

        if (Time == 5)
        {
            TimeNumber.text = "4";
        }

        if (Time == 6)
        {
            TimeNumber.text = "5";
        }

        if (Time == 7)
        {
            WichNight += 1;
            PlayerPrefs.SetFloat("WichNight", WichNight);
            PlayerPrefs.Save();
            SceneManager.LoadScene("6AM");
        }
    }
	
	
	IEnumerator TimeCounter ()
    {
        yield return new WaitForSeconds(60);
        Time += 1;
        SetHour();
        ShowTimeText();
        StartCoroutine(TimeCounter());
	}
}
