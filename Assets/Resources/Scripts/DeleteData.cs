using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteData : MonoBehaviour {

    public GameObject ConfirmButton;

    public float WichNight;

    void Start()
    {
        if (PlayerPrefs.HasKey("WichNight")) WichNight = PlayerPrefs.GetFloat("WichNight", WichNight);
    }

    public void DeleteSave()
    {
        ConfirmButton.SetActive(true);
    }

    public void Confirm()
    {
        WichNight = 1;
        PlayerPrefs.SetFloat("WichNight", WichNight);
        PlayerPrefs.Save();
        ConfirmButton.SetActive(false);
    }

}
