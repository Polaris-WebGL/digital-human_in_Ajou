using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    [SerializeField] 
    GameObject DialogueUI = null;
    [SerializeField] 
    GameObject dialogue = null;

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
        DigitalHuman.GetComponent<Animator>().SetBool("pauseAnim", true);
        DigitalHuman.GetComponent<Animator>().SetBool("startAnim", false);
        roomUI.SetActive(true);
        otherUI.SetActive(false);
        DialogueUI.SetActive(false);
    }
    public void clkAvatar()
    {
        deskCam.enabled = false;
        mainCam.enabled = false;
        avatarCam.enabled = true;
        roomUI.SetActive(false);
        otherUI.SetActive(true);
        DialogueUI.SetActive(true);
        /*if (SceneManager.GetActiveScene().name == "Room_Aseong")
        {
            dialogue.GetComponent<randomDialogue_woman>().Start();
        }
        else if (SceneManager.GetActiveScene().name == "Room_Garam")
        {
            dialogue.GetComponent<randomDialogue_man>().Start();
        }*/
    }
}
