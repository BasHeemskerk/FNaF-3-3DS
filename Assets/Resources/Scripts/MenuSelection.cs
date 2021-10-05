using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class MenuSelection : MonoBehaviour {

    public GameObject NightText2;
    public Text Text;

    public GameObject Cursor;

    public GameObject point1;
    public GameObject point2;
    public GameObject point3;
    public GameObject point4;

    public float CurrPos = 1;
    public float Max = 2;

    public float WichNight;

    public bool NightmareUnlocked;
    public bool ExtraUnlocked;


	void Start ()
    {
        if (PlayerPrefs.HasKey("WichNight")) WichNight = PlayerPrefs.GetFloat("WichNight", WichNight);

        if (WichNight <= 0)
        {
            WichNight = 1;
            PlayerPrefs.SetFloat("WichNight", WichNight);
            PlayerPrefs.Save();
        }

        if (WichNight == 6)
        {
            WichNight = 5;
        }
        else if (WichNight == 7)
        {
            WichNight = 5;
        }

        if (WichNight > 5)
        {
            NightmareUnlocked = true;
        }

        if (WichNight > 6)
        {
            ExtraUnlocked = true;
        }

        Text.text = WichNight.ToString();
    }
	
	void MoveCursor()
    {
        if (CurrPos == 1)
        {
            Cursor.transform.position = point1.transform.position;
            NightText2.SetActive(false);
        }

        if (CurrPos == 2)
        {
            Cursor.transform.position = point2.transform.position;
            NightText2.SetActive(true);
        }

        if (CurrPos == 3)
        {
            if (NightmareUnlocked)
            {
                Cursor.transform.position = point3.transform.position;
                NightText2.SetActive(false);
            }
        }

        if (CurrPos == 4)
        {
            if (NightmareUnlocked)
            {
                if (ExtraUnlocked)
                {
                    Cursor.transform.position = point4.transform.position;
                    NightText2.SetActive(false);
                }
            }
        }
    }

    void Select()
    {
        if (CurrPos == 1)
        {
            WichNight = 1;
            PlayerPrefs.SetFloat("WichNight", WichNight);
            PlayerPrefs.Save();
            GC.Collect();
            SceneManager.LoadScene("NewsPaper");
        }

        if (CurrPos == 2)
        {
            GC.Collect();
            if (WichNight == 1)
            {
                SceneManager.LoadScene("NewsPaper");
            }
            else
            {
                SceneManager.LoadScene("NextNight");
            }
        }

        if (CurrPos == 3)
        {
            WichNight = 6;
            PlayerPrefs.SetFloat("WichNight", WichNight);
            PlayerPrefs.Save();
            GC.Collect();
            SceneManager.LoadScene("NextNight");
        }

        if (CurrPos == 4)
        {
            SceneManager.LoadScene("Extra");
        }
    }

    void Update ()
    {
		if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            CurrPos -= 1;
            MoveCursor();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            CurrPos -= 1;
            MoveCursor();
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            CurrPos += 1;
            MoveCursor();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            CurrPos += 1;
            MoveCursor();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Select();
        }

        if (CurrPos <= 1)
        {
            CurrPos = 1;
        }

        if (CurrPos >= Max)
        {
            CurrPos = Max;
        }

        if (NightmareUnlocked)
        {
            Max = 3;
        }

        if (ExtraUnlocked)
        {
            Max = 4;
        }
        
	}
}
