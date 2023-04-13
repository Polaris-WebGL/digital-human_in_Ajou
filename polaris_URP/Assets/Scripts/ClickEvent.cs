using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEvent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) // 클릭한 경우
        {
            if (gameObject.CompareTag("Device"))
            {
                Application.OpenURL("https://50.ajou.ac.kr/");
            }

            if (gameObject.CompareTag("Map"))
            {
                Application.OpenURL("https://www.ajou.ac.kr/kr/ajou/notice.do");
            }

            if (gameObject.CompareTag("Photo"))
            {
                Application.OpenURL("https://www.ajou.ac.kr/kr/ajou/notice.do");
            }
        }
    }
}
