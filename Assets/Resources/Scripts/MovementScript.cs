using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MovementScript : MonoBehaviour {

    public double Number;
    public float WaitTime = 5;

    private float SpringtrapAiLevel = 2;
    private float ChicaAiLevel = 2;
    private float FoxyAiLevel = 2;
    private float MangleAiLevel = 2;
    private float FreddyAiLevel = 2;
    private float BalloonBoyAiLevel = 2;
    private float ErrorAiLevel = 2;
    private float PuppetAiLevel = 2;

    public double RandomError;

    public float SpringtrapPos;
    public float ChicaPos;
    public float FoxyPos;
    public float ManglePos;
    public float FreddyPos;
    public float BalloonBoyPos;
    public float PuppetPos;

    public float WichNight;

    public GameObject OfficeController;
    //public GameObject Office;
    public GameObject JumpscareController;

    //____________________________//
    public CameraScript camScript;
    public VentilationErrorScript ventErrrorScript;
    public cameraErrorScript camErrorScript;
    public audioErrorScript audErrorScript;
    public MovementScript moveScript;
    public LaughScript laughScript;


	void Start ()
    {
        if (PlayerPrefs.HasKey("WichNight")) WichNight = PlayerPrefs.GetFloat("WichNight", WichNight);

        if (WichNight <= 1)
        {
            SpringtrapAiLevel = 0;
            ChicaAiLevel = 0;
            FoxyAiLevel = 0;
            MangleAiLevel = 0;
            FreddyAiLevel = 0;
            BalloonBoyAiLevel = 0;
            ErrorAiLevel = 0;
            PuppetAiLevel = 0;
        }

        if (WichNight == 2)
        {
            SpringtrapAiLevel = 2;
            ChicaAiLevel = 0;
            FoxyAiLevel = 0;
            MangleAiLevel = 2;
            FreddyAiLevel = 0;
            BalloonBoyAiLevel = 2;
            ErrorAiLevel = 2;
            PuppetAiLevel = 0;
        }

        if (WichNight == 3)
        {
            SpringtrapAiLevel = 6;
            ChicaAiLevel = 2;
            FoxyAiLevel = 2;
            MangleAiLevel = 4;
            FreddyAiLevel = 2;
            BalloonBoyAiLevel = 4;
            ErrorAiLevel = 4;
            PuppetAiLevel = 0;
        }

        if (WichNight == 4)
        {
            SpringtrapAiLevel = 12;
            ChicaAiLevel = 6;
            FoxyAiLevel = 5;
            MangleAiLevel = 8;
            FreddyAiLevel = 4;
            BalloonBoyAiLevel = 8;
            ErrorAiLevel = 8;
            PuppetAiLevel = 2;
        }

        if (WichNight == 5)
        {
            SpringtrapAiLevel = 16;
            ChicaAiLevel = 10;
            FoxyAiLevel = 10;
            MangleAiLevel = 16;
            FreddyAiLevel = 8;
            BalloonBoyAiLevel = 12;
            ErrorAiLevel = 10;
            PuppetAiLevel = 6;
        }

        if (WichNight == 6)
        {
            SpringtrapAiLevel = 20;
            ChicaAiLevel = 16;
            FoxyAiLevel = 16;
            MangleAiLevel = 16;
            FreddyAiLevel = 16;
            BalloonBoyAiLevel = 16;
            ErrorAiLevel = 10;
            PuppetAiLevel = 16;
        }

        if (WichNight > 1)
        {
            StartCoroutine(Wait());
        }
        else
        {
            moveScript.enabled = false;
        }
	}
	
    void GenNumber()
    {
        Number = System.Math.Round(UnityEngine.Random.Range(1f, 20f));
        Number += 1;
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(WaitTime);
        GenNumber();
        AI();
        Wait();
    }

	void AI ()
    {
        if (Number <= SpringtrapAiLevel)
        {
            SpringtrapPos += 1;
            camScript.UpdateCam();
            Debug.Log("Watch out! Springtrap has just moved!");

            GenNumber();
        }

        if (Number <= ChicaAiLevel)
        {
            ChicaPos += 1;
            camScript.UpdateCam();
            Debug.Log("Chica has came closer!");
        }

        if (Number <= FoxyAiLevel)
        {
            FoxyPos += 1;
            camScript.UpdateCam();
            Debug.Log("Foxy has came closer!");
        }

        if (Number <= MangleAiLevel)
        {
            ManglePos += 1;
            camScript.UpdateCam();
            Debug.Log("Mangle has came closer!");
        }

        if (Number <= FreddyAiLevel)
        {
            FreddyPos += 1;
            camScript.UpdateCam();
            Debug.Log("Freddy has came closer!");
        }

        if (Number <= ErrorAiLevel)
        {
            GenerateAndAssignRandomError();
            Debug.Log("Oh no! an error");
        }

        if (Number <= PuppetAiLevel)
        {
            PuppetPos += 1;
            camScript.UpdateCam();
            Debug.Log("Puppet has came closer!");
        }

        StartCoroutine(Wait());
    }

    void GenerateAndAssignRandomError()
    {
        RandomError = System.Math.Round(UnityEngine.Random.Range(1f, 3f));

        if (RandomError == 1)
        {
            Debug.Log("Ventilation error");
            ventErrrorScript.ventilationError = true;
            ventErrrorScript.Error();
        }

        if (RandomError == 2)
        {
            Debug.Log("Audio error");
            laughScript.audioError = true;
            audErrorScript.audioError = true;
            audErrorScript.Error();
        }

        if (RandomError == 3)
        {
            Debug.Log("Camera error");
            camScript.cameraError = true;
            camScript.Error();
            camErrorScript.cameraError = true;
            camErrorScript.Error();
        }
    }

    //my code is shit lol
}
