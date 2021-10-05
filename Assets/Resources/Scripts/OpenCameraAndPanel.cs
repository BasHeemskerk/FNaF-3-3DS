using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class OpenCameraAndPanel : MonoBehaviour {

    public GameObject CameraForward;
    public GameObject CameraBackward;
    public GameObject ControlForward;
    public GameObject ControlBackward;

    public GameObject ControlScreen;

    public GameObject CameraScreen;
    public GameObject BottomScreen;

    public bool ControlPanelOpen;
    public bool CameraPanelOpen;
    public bool isRepairing;

    public float MaxLimit;
    public float Speed;

    public GameObject Office;

    public OfficeMoveScript officeMoveScript;
    public CameraScript camScript;
    public ControlPanelSelection controlPanelSelection;
    public LaughScript laughScript;
	

	void LateUpdate ()
    {
        if (Input.GetKeyDown(KeyCode.L) || Input.GetKeyDown(KeyCode.R))
        {
            CheckPosition();
            CheckIfNotTooFar();
        }
    }

    void CheckIfNotTooFar()
    {
        if (MaxLimit >= 0.2829091f)
        {
            MaxLimit = 0.2829091f;
        }
        else if (MaxLimit <= -0.1f)
        {
            MaxLimit = -0.1f;
        }
    }

    void CheckPosition()
    {
        if (MaxLimit <= 0.1f)
        {
            if (!CameraPanelOpen)
            {
                StartCoroutine(StartCamera());
            }
            else if (CameraPanelOpen)
            {
                StartCoroutine(RemoveCamera());
            }
        }

        if (MaxLimit >= 0.2829091f)
        {
            if (!ControlPanelOpen)
            {
                StartCoroutine(StartControl());
            }
            else if (ControlPanelOpen)
            {
                StartCoroutine(RemoveControl());
            }
        }
    }

    public void CloseControl()
    {
        //can be acessed from ControlPanelSelection.cs
        StartCoroutine(RemoveControl());
    }

    public IEnumerator StartCamera()
    {
        officeMoveScript.CameraPanelUp = true;

        CameraForward.SetActive(true);
        CameraBackward.SetActive(false);

        yield return new WaitForSeconds(0.2f);

        CameraScreen.SetActive(true);
        BottomScreen.SetActive(true);

        camScript.enabled = true;
        officeMoveScript.enabled = false;
        Office.SetActive(false);

        CameraPanelOpen = true;
    }

    public IEnumerator StartControl()
    {
        officeMoveScript.ControlPanelUp = true;
        controlPanelSelection.ControlPanelUp = true;

        ControlForward.SetActive(true);
        ControlBackward.SetActive(false);

        yield return new WaitForSeconds(0.3f);

        ControlScreen.SetActive(true);

        officeMoveScript.enabled = false;
        controlPanelSelection.enabled = true;
        laughScript.enabled = true;

        ControlPanelOpen = true;
    }

    public IEnumerator RemoveCamera()
    {
        CameraForward.SetActive(false);
        CameraBackward.SetActive(true);

        officeMoveScript.CameraPanelUp = false;
        controlPanelSelection.ControlPanelUp = false;

        CameraScreen.SetActive(false);
        BottomScreen.SetActive(false);

        Office.SetActive(true);

        yield return new WaitForSeconds(0.2f);

        CameraBackward.SetActive(false);

        camScript.enabled = false;
        officeMoveScript.enabled = true;

        CameraPanelOpen = false;
    }

    public IEnumerator RemoveControl()
    {
        if (!isRepairing)
        {
            ControlForward.SetActive(false);
            ControlBackward.SetActive(true);

            officeMoveScript.ControlPanelUp = false;

            ControlScreen.SetActive(false);

            yield return new WaitForSeconds(0.3f);

            ControlBackward.SetActive(false);

            controlPanelSelection.ControlPanelUp = false;
            controlPanelSelection.enabled = false;
            officeMoveScript.enabled = true;
            laughScript.enabled = false;

            ControlPanelOpen = false;
        }
    }
}
