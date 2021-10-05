using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class fifty_fifty : MonoBehaviour {

    public double Chance;
    public double MakeNextWaitTime;
    public float NextWaitTime = 8;
    public GameObject OfficeObject;

    public MovementScript moveScript;
    public fifty_fifty fiftyChance;

    public float WichNight;

    void Start()
    {
        StartCoroutine(CalculateMoveChance());

        if (PlayerPrefs.HasKey("WichNight")) WichNight = PlayerPrefs.GetFloat("WichNight", WichNight);

        if (WichNight == 1)
        {
            fiftyChance.enabled = false;
        }
    }

    void SetChance()
    {
        if (Chance < 50)
        {
            if (moveScript.SpringtrapPos == 0)
            {
                moveScript.SpringtrapPos = -14;
            }

            if (moveScript.SpringtrapPos == 1)
            {
                moveScript.SpringtrapPos = -11;
            }

            if (moveScript.SpringtrapPos == 7)
            {
                moveScript.SpringtrapPos = -12;
            }

            if (moveScript.SpringtrapPos == 5)
            {
                moveScript.SpringtrapPos = -13;
            }

            if (moveScript.SpringtrapPos == 2)
            {
                moveScript.SpringtrapPos = -15;
            }


            if (moveScript.SpringtrapPos == -14)
            {
                moveScript.SpringtrapPos = 2;
            }

            if (moveScript.SpringtrapPos == -11)
            {
                moveScript.SpringtrapPos = 7;
            }

            if (moveScript.SpringtrapPos == -12)
            {
                moveScript.SpringtrapPos = 16;
            }

            if (moveScript.SpringtrapPos == -13)
            {
                moveScript.SpringtrapPos = 5;
            }

            if (moveScript.SpringtrapPos == -15)
            {
                moveScript.SpringtrapPos = 17;
            }
        }

        else if (Chance > 50)
        {
            if (moveScript.SpringtrapPos == -14)
            {
                moveScript.SpringtrapPos = 0;
            }

            if (moveScript.SpringtrapPos == -11)
            {
                moveScript.SpringtrapPos = 1;
            }

            if (moveScript.SpringtrapPos == -12)
            {
                moveScript.SpringtrapPos = 7;
            }

            if (moveScript.SpringtrapPos == -13)
            {
                moveScript.SpringtrapPos = 5;
            }

            if (moveScript.SpringtrapPos == -15)
            {
                moveScript.SpringtrapPos = 2;
            }
        }
    }
    
    IEnumerator CalculateMoveChance ()
    {
        yield return new WaitForSeconds(NextWaitTime);
        Chance = System.Math.Round(UnityEngine.Random.Range(0f, 100f));
        MakeNextWaitTime = System.Math.Round(UnityEngine.Random.Range(1f, 20f));
        MakeNextWaitTime = NextWaitTime;
        SetChance();
        StartCoroutine(CalculateMoveChance());
	}
}
