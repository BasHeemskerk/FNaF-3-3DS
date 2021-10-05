using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficeMoveScript : MonoBehaviour {

    public GameObject OfficeGroup;

    public float MaxLimit;
    public float Speed;

    //-------------
    //checking if control panel or camera is up
    //-------------

    public bool ControlPanelUp;
    public bool CameraPanelUp;

    public GameObject OfficeController;
    public GameObject JumpscareController;

    public OpenCameraAndPanel openCam_Panel;

	void Update ()
    {
        if (Input.GetKey(KeyCode.Keypad4))
        {
            MoveLeft();
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            MoveLeft();
        }

        if (Input.GetKey(KeyCode.Keypad6))
        {
            MoveRight();
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            MoveRight();
        }

        if (MaxLimit >= 0.2829091f)
        {
            MaxLimit = 0.2829091f;
        }
        else if (MaxLimit <= -0.1f)
        {
            MaxLimit = -0.1f;
        }

    }

    void MoveLeft()
    {
        MaxLimit += 1 * Time.deltaTime;
        openCam_Panel.MaxLimit = MaxLimit;
        if (MaxLimit < 0.2829091f)
        {
            OfficeGroup.transform.Translate(Vector3.right * Speed * Time.deltaTime);
        }
    }

    void MoveRight()
    {
        MaxLimit -= 1 * Time.deltaTime;
        openCam_Panel.MaxLimit = MaxLimit;

        if (MaxLimit > -0.1f)
        {
            OfficeGroup.transform.Translate(Vector3.left * Speed * Time.deltaTime);
        }
    }

}
