using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaughScript : MonoBehaviour {

    public AudioSource Laugh1;
    public AudioSource Laugh2;
    public AudioSource Laugh3;
    public double WichLaugh;

    public GameObject Cam1B;
    public GameObject Cam2B;
    public GameObject Cam3B;
    public GameObject Cam4B;
    public GameObject Cam5B;
    public GameObject Cam6B;
    public GameObject Cam7B;
    public GameObject Cam8B;
    public GameObject Cam9B;
    public GameObject Cam10B;

    public GameObject PlayAudio;
    public GameObject PlayAudioIcon;

    public float currCam;
    public MovementScript moveScript;

    public bool audioError;

    void Start()
    {
        //here is nothing, this is just to be able to disable the script in the inspector
    }

    public void PlayAudioSelector()
    {
        if (!audioError)
        {
            GenLaughNum();
        }
    }

    void GenLaughNum()
    {
        WichLaugh = System.Math.Round(UnityEngine.Random.Range(1f, 3f));

        PlayGenLaugh();
    }

    void PlayGenLaugh()
    {
        if (WichLaugh == 1)
        {
            Laugh1.Play();
        }

        if (WichLaugh == 2)
        {
            Laugh2.Play();
        }

        if (WichLaugh == 3)
        {
            Laugh3.Play();
        }

        SetAudioWaveIconPos();
        MoveAnimatronic();
    }

    void SetAudioWaveIconPos()
    {

        if (currCam == 1)
        {
            PlayAudioIcon.transform.position = Cam1B.transform.position;
        }

        if (currCam == 2)
        {
            PlayAudioIcon.transform.position = Cam2B.transform.position;
        }

        if (currCam == 3)
        {
            PlayAudioIcon.transform.position = Cam3B.transform.position;
        }

        if (currCam == 4)
        {
            PlayAudioIcon.transform.position = Cam4B.transform.position;
        }

        if (currCam == 5)
        {
            PlayAudioIcon.transform.position = Cam5B.transform.position;
        }

        if (currCam == 6)
        {
            PlayAudioIcon.transform.position = Cam6B.transform.position;
        }

        if (currCam == 7)
        {
            PlayAudioIcon.transform.position = Cam7B.transform.position;
        }

        if (currCam == 8)
        {
            PlayAudioIcon.transform.position = Cam8B.transform.position;
        }

        if (currCam == 9)
        {
            PlayAudioIcon.transform.position = Cam9B.transform.position;
        }

        if (currCam == 10)
        {
            PlayAudioIcon.transform.position = Cam10B.transform.position;
        }

        StartCoroutine(ShowAudioWaveIcon());
    }

    IEnumerator ShowAudioWaveIcon()
    {
        PlayAudioIcon.SetActive(true);
        yield return new WaitForSeconds(2);
        PlayAudioIcon.SetActive(false);
    }

    void MoveAnimatronic()
    {
        if (moveScript.SpringtrapPos < currCam)
        {
            PlusSpringtrapPos();
        }
        else if (moveScript.SpringtrapPos > currCam)
        {
            MinusSpringtrapPos();
        }
    }

    void PlusSpringtrapPos()
    {
        moveScript.SpringtrapPos += 1;
    }

    void MinusSpringtrapPos()
    {
        moveScript.SpringtrapPos -= 1;
    }
}
