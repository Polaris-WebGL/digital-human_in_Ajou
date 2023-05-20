using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickEvent : MonoBehaviour
{
    private bool mousePressed;
    private Vector3 mousePosition;
    public Camera mainCamera;
    public Camera overCamera;
    public GameObject BackUI;
    public GameObject MenuUI;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 클릭한 경우
        {
            mousePressed = Input.GetMouseButtonDown(0);
            mousePosition = Input.mousePosition;
        }
    }
    private void FixedUpdate()
    {
        Ray ray = UnityEngine.Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (mousePressed && Physics.Raycast(ray, out hit))
        {
            if (hit.transform.name == "polySurface29" || hit.transform.name == "polySurface31" || hit.transform.name == "polySurface32" || hit.transform.name == "polySurface33")
            {
                Debug.Log("desk Hit");
                
                //책상 뷰로 전환
                mainCamera.enabled = false;
                overCamera.enabled = true;
                BackUI.SetActive(true);
                MenuUI.SetActive(false);
                
                if (hit.transform.name == "switch1")
                {
                    Debug.Log("switch Hit");
                    Application.OpenURL("https://50.ajou.ac.kr/");
                }

                else if (hit.transform.name == "map")
                {
                    Debug.Log("map Hit");
                    Application.OpenURL("https://www.ajou.ac.kr/kr/ajou/notice.do");
                }

                else if (hit.transform.name == "card1")
                {
                    Debug.Log("card Hit");
                    Application.OpenURL("https://www.ajou.ac.kr/kr/ajou/notice.do");
                }
            
                else if (hit.transform.name == "apply1")
                {
                    Debug.Log("apply Hit");
                    Application.OpenURL("./WebSite/ClubList.html");
                }
            
                else if (hit.transform.name == "pamphlet1")
                {
                    Debug.Log("pamphlet Hit");
                
                }
                
                else if (hit.transform.name == "pCube30")
                {
                    Debug.Log("photo Hit");
                
                }
            }
        }
    }

    public void OnClickExit()
    {
        Debug.Log("Back button Click");
        mainCamera.enabled = true;
        overCamera.enabled = false;
        
        SceneManager.LoadScene("Room");
        MenuUI.SetActive(true);
    }

    public void OnClickMenu()
    {
        Debug.Log("Menu button Click");
        
        
    }
}
