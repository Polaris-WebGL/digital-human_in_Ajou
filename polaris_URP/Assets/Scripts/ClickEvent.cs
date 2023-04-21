using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class ClickEvent : MonoBehaviour
{
    private bool mousePressed;
    private Vector3 mousePosition;

    void Update()
    {
        if (Input.GetMouseButton(0)) // 클릭한 경우
        {
            mousePressed = Input.GetMouseButton(0);
            mousePosition = Input.mousePosition;
        }
    }

    private void FixedUpdate()
    {
        Ray ray = UnityEngine.Camera.main.ScreenPointToRay(mousePosition);
        RaycastHit hit;

        if (mousePressed && Physics.Raycast(ray, out hit))
        {
            if (hit.collider.name == "switch2")
            {
                Debug.Log("switch Hit");
                Application.OpenURL("https://50.ajou.ac.kr/");
            }

            if (hit.collider.name == "map1")
            {
                Debug.Log("map Hit");
                Application.OpenURL("https://www.ajou.ac.kr/kr/ajou/notice.do");
            }

            if (hit.collider.name == "card1")
            {
                Debug.Log("card Hit");
                Application.OpenURL("https://www.ajou.ac.kr/kr/ajou/notice.do");
            }
        }
    }
}
