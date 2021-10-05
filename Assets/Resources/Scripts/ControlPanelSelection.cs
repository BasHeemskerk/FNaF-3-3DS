using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlPanelSelection : MonoBehaviour {

    public GameObject point1;
    public GameObject point2;
    public GameObject point3;
    public GameObject point4;
    public GameObject point5;

    public GameObject Pointer;

    public GameObject point6;
    public GameObject point7;
    public GameObject point8;
    public GameObject point9;

    public GameObject repairing;

    public bool ControlPanelUp;
    public bool isRepairing;

    public float WichPos = 1;

    public AudioSource Beep;
    public AudioSource RepairBeeping;
    public AudioSource DoneRepairBeep;

    public GameObject ControlScreen;

    public GameObject OfficeController;


    public GameObject camErrorSprite;

    public VentilationErrorScript ventErrorScript;
    public audioErrorScript audErrorScript;
    public cameraErrorScript camErrorScript;
    public CameraScript camScript;
    public OpenCameraAndPanel OpenCam_Panel;
    public OfficeMoveScript officeMoveScript;
    public LaughScript laughScript;

    void Start()
    {
        UpdatePos();
    }

    void UpdatePos()
    {
        Beep.Play();

        if (WichPos == 1)
        {
            Pointer.transform.position = point1.transform.position;
        }

        if (WichPos == 2)
        {
            Pointer.transform.position = point2.transform.position;
        }

        if (WichPos == 3)
        {
            Pointer.transform.position = point3.transform.position;
        }

        if (WichPos == 4)
        {
            Pointer.transform.position = point4.transform.position;
        }

        if (WichPos == 5)
        {
            Pointer.transform.position = point5.transform.position;
        }
    }

    void A_Pressed()
    {
        if (ControlPanelUp)
        {
            if (!isRepairing)
            {
                if (WichPos == 1)
                {
                    isRepairing = true;
                    OpenCam_Panel.isRepairing = true;
                    repairing.SetActive(true);
                    repairing.transform.position = point6.transform.position;

                    StartCoroutine(repairAudio());
                }

                if (WichPos == 2)
                {
                    isRepairing = true;
                    OpenCam_Panel.isRepairing = true;
                    repairing.SetActive(true);
                    repairing.transform.position = point7.transform.position;

                    StartCoroutine(repairCamera());
                }

                if (WichPos == 3)
                {

                    isRepairing = true;
                    OpenCam_Panel.isRepairing = true;
                    repairing.SetActive(true);
                    repairing.transform.position = point8.transform.position;

                    StartCoroutine(repairVentilation());
                }

                if (WichPos == 4)
                {

                    isRepairing = true;
                    OpenCam_Panel.isRepairing = true;
                    repairing.SetActive(true);
                    repairing.transform.position = point9.transform.position;

                    StartCoroutine(repairAll());
                }

                if (WichPos == 5)
                {
                    OpenCam_Panel.CloseControl();
                    officeMoveScript.enabled = true;
                    ControlScreen.SetActive(false);
                }
            }
        }
    }

    IEnumerator repairAll()
    {
        StartCoroutine(BeepingTimer());
        yield return new WaitForSeconds(15);
        Debug.Log("Repaired all!");
        OpenCam_Panel.isRepairing = false;
        //
        audErrorScript.audioError = false;
        camErrorScript.cameraError = false;
        ventErrorScript.ventilationError = false;
        audErrorScript.EndOfError();
        camErrorScript.EndOfError();
        ventErrorScript.EndOfError();
        //
        repairing.SetActive(false);
        DoneRepairBeep.Play();
        isRepairing = false;
    }

    IEnumerator BeepingTimer()
    {
        if (isRepairing)
        {
            yield return new WaitForSeconds(1.3f);
            RepairBeeping.Play();
            StartCoroutine(BeepingTimer());
        }
    }

    IEnumerator repairAudio()
    {
        StartCoroutine(BeepingTimer());
        yield return new WaitForSeconds(10);
        Debug.Log("Repaired audio!");
        gameObject.GetComponent<OpenCameraAndPanel>().isRepairing = false;
        //
        laughScript.audioError = false;
        audErrorScript.EndOfError();
        //
        repairing.SetActive(false);
        DoneRepairBeep.Play();
        isRepairing = false;
    }

    IEnumerator repairCamera()
    {
        StartCoroutine(BeepingTimer());
        yield return new WaitForSeconds(10);
        Debug.Log("Repaired camera!");
        gameObject.GetComponent<OpenCameraAndPanel>().isRepairing = false;
        //
        camErrorScript.cameraError = false;
        camErrorScript.EndOfError();
        //
        repairing.SetActive(false);
        DoneRepairBeep.Play();
        isRepairing = false;
    }

    IEnumerator repairVentilation()
    {
        StartCoroutine(BeepingTimer());
        yield return new WaitForSeconds(10);
        Debug.Log("Repaired ventilation!");
        OpenCam_Panel.isRepairing = false;
        //
        ventErrorScript.ventilationError = false;
        ventErrorScript.EndOfError();
        //
        repairing.SetActive(false);
        DoneRepairBeep.Play();
        isRepairing = false;
    }

	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            A_Pressed();
        }

        if (Input.GetKeyDown(KeyCode.Keypad8) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            Add();
        }

        if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            Remove();
        }


        if (WichPos < 1)
        {
            WichPos = 1;
        }

        if (WichPos > 5)
        {
            WichPos = 5;
        }
    }

    void Add()
    {
        if (ControlPanelUp)
        {
            if (!isRepairing)
            {
                WichPos -= 1;
                UpdatePos();
            }
        }
    }

    void Remove()
    {
        if (ControlPanelUp)
        {
            if (!isRepairing)
            {
                WichPos += 1;
                UpdatePos();
            }
        }
    }
}
