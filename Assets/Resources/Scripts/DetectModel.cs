using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.N3DS;
using UnityEngine.UI;

public class DetectModel : MonoBehaviour {

    public Text WhatModel;
    public bool isMenu;

    public GameObject GameController;

	void Start ()
    {
        GameController = GameObject.FindGameObjectWithTag("GameController");

        if (UnityEngine.N3DS.Application.isRunningAsExtApplication == true)
        {
            NewModel();
        }

        if (UnityEngine.N3DS.Application.isRunningAsExtApplication == false)
        {
            OldModel();
        }
    }

    void NewModel()
    {
        if (isMenu)
        {
            WhatModel.text = "New 3DS [performance is overall increased]";
        }
        else if (!isMenu)
        {
            WhatModel.text = "New 3DS";
        }
    }

    void OldModel()
    {
        if (isMenu)
        {
            WhatModel.text = "Old 3DS [WARNING: performance can drop]";
        }
        else if (!isMenu)
        {
            WhatModel.text = "Old 3DS";
        }

        GameController.GetComponent<oldModel>().isOldModel();
    }
}
