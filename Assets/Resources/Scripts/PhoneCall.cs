using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneCall : MonoBehaviour {


    public AudioSource Call1;
    public AudioSource Call2;
    public AudioSource Call3;
    public AudioSource Call4;
    public AudioSource Call5;
    public AudioSource Call6;

    public GameObject Call1ToDestroy;
    public GameObject Call2ToDestroy;
    public GameObject Call3ToDestroy;
    public GameObject Call4ToDestroy;
    public GameObject Call5ToDestroy;
    public GameObject Call6ToDestroy;

    public PhoneCall phoneCall;

    public float WichNight;


	void Start ()
    {
        if (PlayerPrefs.HasKey("WichNight")) WichNight = PlayerPrefs.GetFloat("WichNight");
        StartCall();
	}
	
    void StartCall()
    {
        if (WichNight == 1)
        {
            Call1.Play();

            Destroy(Call2ToDestroy);
            Destroy(Call3ToDestroy);
            Destroy(Call4ToDestroy);
            Destroy(Call5ToDestroy);
            Destroy(Call6ToDestroy);
        }

        if (WichNight == 2)
        {
            Call2.Play();

            Destroy(Call1ToDestroy);
            Destroy(Call3ToDestroy);
            Destroy(Call4ToDestroy);
            Destroy(Call5ToDestroy);
            Destroy(Call6ToDestroy);
        }

        if (WichNight == 3)
        {
            Call3.Play();

            Destroy(Call1ToDestroy);
            Destroy(Call2ToDestroy);
            Destroy(Call4ToDestroy);
            Destroy(Call5ToDestroy);
            Destroy(Call6ToDestroy);
        }

        if (WichNight == 4)
        {
            Call4.Play();

            Destroy(Call1ToDestroy);
            Destroy(Call2ToDestroy);
            Destroy(Call3ToDestroy);
            Destroy(Call5ToDestroy);
            Destroy(Call6ToDestroy);
        }

        if (WichNight == 5)
        {
            Call5.Play();

            Destroy(Call1ToDestroy);
            Destroy(Call2ToDestroy);
            Destroy(Call3ToDestroy);
            Destroy(Call4ToDestroy);
            Destroy(Call6ToDestroy);
        }

        if (WichNight == 6)
        {
            Call6.Play();

            Destroy(Call1ToDestroy);
            Destroy(Call2ToDestroy);
            Destroy(Call3ToDestroy);
            Destroy(Call4ToDestroy);
            Destroy(Call5ToDestroy);
        }

        End();
    }

    void End()
    {
        phoneCall.enabled = false;
    }
}
