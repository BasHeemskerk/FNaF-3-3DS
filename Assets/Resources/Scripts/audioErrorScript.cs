using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioErrorScript : MonoBehaviour {

    public GameObject errorMsg1;
    public GameObject audioErrorSprite;

    public bool audioError;

    public void Error ()
    {
        Check();
	}

    public void EndOfError()
    {
        Check();
    }
	

	void Check ()
    {
        if (audioError)
        {
            errorMsg1.SetActive(true);
            audioErrorSprite.SetActive(true);
        }
        else if (!audioError)
        {
            errorMsg1.SetActive(false);
            audioErrorSprite.SetActive(false);
        }
    }
}
