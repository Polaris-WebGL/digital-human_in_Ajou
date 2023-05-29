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
    /*private bool mousePressed;
    private Vector3 mousePosition;
    
    
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

        if (mousePressed && Physics.Raycast(ray, out hit, 300))
        {
            if (hit.collider.name != null)
            {

                if (hit.collider.name == "switch1")
                {
                    Debug.Log("switch Hit");
                    Application.OpenURL("https://consult.mncapro.co.kr/solution/ajou/department/index.html");
                }
                
                else if (hit.collider.name == "map")
                {
                    Debug.Log("map Hit");
                    Application.OpenURL("http://www.iajou.ac.kr/ajouvr.jsp");
                }

                else if (hit.collider.name == "book1")
                {
                    Debug.Log("book1 Hit");
                    Application.OpenURL("http://www.iajou.ac.kr/main.do");            
                }
                
                else if (hit.collider.name == "book3")
                {
                    Debug.Log("book3 Hit");
                    Application.OpenURL("https://www.ajou.ac.kr/oia/index.do");            
                }
                
                else if (hit.collider.name == "book4")
                {
                    Debug.Log("book4 Hit");
                    Application.OpenURL("https://moca.ajou.ac.kr");            
                }
                
                else if (hit.collider.name == "book5")
                {
                    Debug.Log("book5 Hit");
                    Application.OpenURL("https://job.ajou.ac.kr/");            
                }
                
                else if (hit.collider.name == "book6")
                {
                    Debug.Log("book6 Hit");
                    Application.OpenURL("https://www.ajou.ac.kr/iadmissions/index.do");            
                }
                
                else if (hit.collider.name == "book7")
                {
                    Debug.Log("book7 Hit");
                    Application.OpenURL("https://hub.ajou.ac.kr/clientMain/a/t/main.do");            
                }
            }

        }
    }*/
}
