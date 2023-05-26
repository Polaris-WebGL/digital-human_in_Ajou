using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField]
    Camera mainCam = null;
    [SerializeField]
    Camera deskCam = null;
    [SerializeField]
    Camera avatarCam = null;
    [SerializeField]
    GameObject DigitalHuman = null;
    [SerializeField]
    GameObject roomUI = null;
    [SerializeField]
    GameObject otherUI = null;

    public void clkDesk()
    {
        deskCam.enabled = true;
        mainCam.enabled = false;
        avatarCam.enabled = false;
        DigitalHuman.SetActive(false);
        roomUI.SetActive(false);
        otherUI.SetActive(true);
    }
    public void clkBackBut()
    {

        deskCam.enabled = false;
        mainCam.enabled = true;
        avatarCam.enabled = false;
        DigitalHuman.SetActive(true);
        roomUI.SetActive(true);
        otherUI.SetActive(false);
    }
    public void clkAvatar()
    {
        deskCam.enabled = false;
        mainCam.enabled = false;
        avatarCam.enabled = true;
        roomUI.SetActive(false);
        otherUI.SetActive(true);
    }
}
