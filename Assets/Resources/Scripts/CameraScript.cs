using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CameraScript : MonoBehaviour
{

    //------------------------------------------------------------------------
    public Image CamViewer;

    public Sprite Cam1_1;
    //public Sprite Cam1_2;
    //
    public Sprite Cam2_1;
    //public Sprite Cam2_2;
    public Sprite Cam2_3;
    //public Sprite Cam2_4;
    public Sprite Cam2_5;
    //public Sprite Cam2_6;
    //
    public Sprite Cam3_1;
    public Sprite Cam3_2;
    public Sprite Cam3_3;
    //
    public Sprite Cam4_1;
    public Sprite Cam4_2;
    public Sprite Cam4_3;
    //
    public Sprite cam5_1;
    //public Sprite cam5_2;
    public Sprite cam5_3;
    //public Sprite cam5_4;
    public Sprite cam5_5;
    //public Sprite cam5_6;
    //
    public Sprite cam6_1;
    //public Sprite cam6_2;
    public Sprite cam6_3;
    //public Sprite cam6_4;
    public Sprite cam6_5;
    //public Sprite cam6_6;
    //
    public Sprite cam7_1;
    //public Sprite cam7_2;
    public Sprite cam7_3;
    //public Sprite cam7_4;
    public Sprite cam7_5;
    //public Sprite cam7_6;
    public Sprite cam7_8;
    //public Sprite cam7_9;
    //
    public Sprite cam8_1;
    //public Sprite cam8_2;
    public Sprite cam8_3;
    //public Sprite cam8_4;
    public Sprite cam8_5;
    //public Sprite cam8_6;
    //
    public Sprite cam9_1;
    public Sprite cam9_2;
    public Sprite cam9_3;
    //
    public Sprite cam10_1;
    public Sprite cam10_2;
    public Sprite cam10_3;
    //
    public Sprite cam11_1;
    public Sprite cam11_2;
    //
    public Sprite cam12_1;
    public Sprite cam12_2;
    //
    public Sprite cam13_1;
    public Sprite cam13_2;
    //
    public Sprite cam14_1;
    public Sprite cam14_2;
    //
    public Sprite cam15_1;
    public Sprite cam15_2;
    //----------------------------------------------------------------------

    //----------------------------------------------------------------------

    //----------------------------------------------------------------------

    public float CurrCamera = 2;

    //public GameObject OfficeController;

    public bool isBuildingMap = true;
    public bool isVentMap = false;

    //----------------------------------------------------------------------
    public GameObject buildingMap;
    public GameObject VentMap;
    //----------------------------------------------------------------------

    //----------------------------------------------------------------------

    //------------------------------------------------------------------------
    public double RandomAddPos;

    public float AddThree = 3;

    public float currCam;

    public bool cameraError = false;

    public MovementScript moveScript;
    public LaughScript laughScript;

    public float springtrapPos;

    void Start()
    {
        currCam = 2;
        //here is nothing, this is just to be able to disable the script in the inspector
    }

    private void Awake()
    {
        Error();
    }

    public void UpdateCam()
    {
        if (currCam == 1)
        {
            Cam1();
        }

        if (currCam == 2)
        {
            Cam2();
        }

        if (currCam == 3)
        {
            Cam3();
        }

        if (currCam == 4)
        {
            Cam4();
        }

        if (currCam == 5)
        {
            Cam5();
        }

        if (currCam == 6)
        {
            Cam6();
        }

        if (currCam == 7)
        {
            Cam7();
        }

        if (currCam == 8)
        {
            Cam8();
        }

        if (currCam == 9)
        {
            Cam9();
        }

        if (currCam == 10)
        {
            Cam10();
        }

        if (currCam == 11)
        {
            Cam11();
        }

        if (currCam == 12)
        {
            Cam12();
        }

        if (currCam == 13)
        {
            Cam13();
        }

        if (currCam == 14)
        {
            Cam14();
        }

        if (currCam == 15)
        {
            Cam15();
        }
    }

    public void Error()
    {
        if (cameraError)
        {
            CamViewer.enabled = false;
        }
        else if (!cameraError)
        {
            CamViewer.enabled = true;
        }
    }


    public void Cam1()
    {
        CamViewer.sprite = Cam1_1;

        currCam = 1;
        laughScript.currCam = currCam;
    }

    public void Cam2()
    {
        CamViewer.sprite = Cam2_1;

        currCam = 2;
        laughScript.currCam = currCam;

        if (moveScript.SpringtrapPos == 15)
        {
            CamViewer.sprite = Cam2_5;
        }
    }

    public void Cam3()
    {
        CamViewer.sprite = Cam3_1;

        currCam = 3;
        laughScript.currCam = currCam;

        if (moveScript.SpringtrapPos == 13)
        {
            CamViewer.sprite = Cam3_2;
        }

        if (moveScript.SpringtrapPos == 14)
        {
            CamViewer.sprite = Cam3_3;
        }
    }

    public void Cam4()
    {
        CamViewer.sprite = Cam4_1;

        currCam = 4;
        laughScript.currCam = currCam;

        if (moveScript.SpringtrapPos == 11)
        {
            CamViewer.sprite = Cam4_2;
        }

        if (moveScript.SpringtrapPos == 12)
        {
            CamViewer.sprite = Cam4_3;
        }
    }

    public void Cam5()
    {
        CamViewer.sprite = cam5_1;

        currCam = 5;
        laughScript.currCam = currCam;

        if (moveScript.SpringtrapPos == 9)
        {
            CamViewer.sprite = cam5_5;
        }

        if (moveScript.SpringtrapPos == 10)
        {
            CamViewer.sprite = cam5_3;
        }
    }

    public void Cam6()
    {
        CamViewer.sprite = cam6_1;

        currCam = 6;
        laughScript.currCam = currCam;

        if (moveScript.SpringtrapPos == 7)
        {
            CamViewer.sprite = cam6_5;
        }

        if (moveScript.SpringtrapPos == 8)
        {
            CamViewer.sprite = cam6_3;
        }
    }

    public void Cam7()
    {
        CamViewer.sprite = cam7_1;

        currCam = 7;
        laughScript.currCam = currCam;

        if (moveScript.SpringtrapPos == 5)
        {
            CamViewer.sprite = cam7_5;
        }

        if (moveScript.SpringtrapPos == 6)
        {
            CamViewer.sprite = cam7_8;
        }
    }

    public void Cam8()
    {
        CamViewer.sprite = cam8_1;

        currCam = 8;
        laughScript.currCam = currCam;

        if (moveScript.SpringtrapPos == 3)
        {
            CamViewer.sprite = cam8_5;
        }

        if (moveScript.SpringtrapPos == 4)
        {
            CamViewer.sprite = cam8_3;
        }
    }

    public void Cam9()
    {

        CamViewer.sprite = cam9_1;

        currCam = 9;
        laughScript.currCam = currCam;

        if (moveScript.SpringtrapPos == 1)
        {
            CamViewer.sprite = cam9_3;
        }
        if (moveScript.SpringtrapPos == 2)
        {
            CamViewer.sprite = cam9_2;
        }
    }

    public void Cam10()
    {
        CamViewer.sprite = cam10_1;

        currCam = 10;
        laughScript.currCam = currCam;

        if (moveScript.SpringtrapPos == -1)
        {
            CamViewer.sprite = cam10_2;
        }
    }

    public void Cam11()
    {
        CamViewer.sprite = cam11_1;

        currCam = 11;
        laughScript.currCam = currCam;

        if (moveScript.SpringtrapPos == -11)
        {
            CamViewer.sprite = cam11_2;
        }
    }

    public void Cam12()
    {
        CamViewer.sprite = cam12_1;

        currCam = 12;
        laughScript.currCam = currCam;

        if (moveScript.SpringtrapPos == -12)
        {
            CamViewer.sprite = cam12_2;
        }
    }

    public void Cam13()
    {
        CamViewer.sprite = cam13_1;

        currCam = 13;
        laughScript.currCam = currCam;

        if (moveScript.SpringtrapPos == -13)
        {
            CamViewer.sprite = cam13_2;
        }
    }

    public void Cam14()
    {
        CamViewer.sprite = cam14_1;

        currCam = 14;
        laughScript.currCam = currCam;

        if (moveScript.SpringtrapPos == -14)
        {
            CamViewer.sprite = cam14_2;
        }
    }

    public void Cam15()
    {
        CamViewer.sprite = cam15_1;

        currCam = 15;
        laughScript.currCam = currCam;

        if (moveScript.SpringtrapPos == -15)
        {
            CamViewer.sprite = cam15_2;
        }
    }

    public void ChangeMapVent()
    {
        if (isBuildingMap)
        {
            buildingMap.SetActive(false);
            VentMap.SetActive(true);
            laughScript.PlayAudio.SetActive(false);

            isVentMap = true;

            isBuildingMap = false;
        }
    }

    public void ChangeMapBuilding()
    {
        buildingMap.SetActive(true);
        VentMap.SetActive(false);
        laughScript.PlayAudio.SetActive(true);

        isBuildingMap = true;

        isVentMap = false;
    }

    //can you see how trash this code is, i have to learn to make it shorter and more efficient omg lmao XDDDD
}
