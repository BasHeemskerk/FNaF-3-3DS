using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VentilationErrorScript : MonoBehaviour {

    public bool ventilationError;

    public GameObject Office;
    public GameObject HeavyBreathingLayer;

    public GameObject Breathing;
    public GameObject AlarmSound;

    public GameObject ventilationErrorSprite;
    public GameObject errorMsg3;

    public Animator officeAnimator;
    public Animator breathingAnimator;

    public void Error()
    {
        Check();
    }

    public void EndOfError()
    {
        Check();
    }

    void Check()
    {
        if (ventilationError)
        {

            officeAnimator.enabled = true;
            breathingAnimator.enabled = true;

            Breathing.SetActive(true);
            AlarmSound.SetActive(true);

            errorMsg3.SetActive(true);

            ventilationErrorSprite.SetActive(true);
        }
        else if (!ventilationError)
        {
            officeAnimator.Play("Flash", -1, 0f);
            officeAnimator.enabled = false;
            breathingAnimator.Play("Breathing", -1, 0);
            breathingAnimator.enabled = false;

            Breathing.SetActive(false);
            AlarmSound.SetActive(false);

            errorMsg3.SetActive(false);

            ventilationErrorSprite.SetActive(false);
        }
    }
}
