using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraErrorScript : MonoBehaviour {


    public GameObject camErrorSprite;
    public GameObject errorMsg2;

    public bool cameraError;


    public void Error()
    {
        Check();
    }

    public void EndOfError()
    {
        Check();
    }

    void Check ()
    {
        if (cameraError)
        {
            errorMsg2.SetActive(true);
            camErrorSprite.SetActive(true);
        }
        else if (!cameraError)
        {
            errorMsg2.SetActive(false);
            camErrorSprite.SetActive(false);
        }
	}
}
