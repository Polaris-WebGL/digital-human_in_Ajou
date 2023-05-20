using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    private bool mousePressed;
    private Vector3 mousePosition;
    public GameObject BackUI;
    public GameObject MenuUI;
    
    void Update()
    {
        Ray ray = UnityEngine.Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0) && Physics.Raycast(ray, out hit, 30.0f))
        {
            
        }
    }

    public void OnClickExit()
    {
        Debug.Log("Back button Click");

        SceneManager.LoadScene("Room");
        MenuUI.SetActive(true);
    }

    public void OnClickMenu()
    {
        Debug.Log("Menu button Click");
        
        
    }
}
