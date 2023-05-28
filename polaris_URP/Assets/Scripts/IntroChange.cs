using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using Debug = UnityEngine.Debug;

public class IntroChange : MonoBehaviour
{
    public GameObject ManOption; //옵션 버튼
    public GameObject WomanOption; //옵션 버튼

    //public GameObject Man; //남자 모델
    //public GameObject Woman; //여자 모델
    
    //public GameObject ManText; //남자 대사
    //public GameObject WomanText; //여자 대사
    
    int cnt = 0; //누른 횟수
    public void MenuClick()
    {
        ManOption.SetActive(true);
        WomanOption.SetActive(true);
        cnt += 1;
        Debug.Log("menu click");

        if (cnt % 2 == 0)
        {
            ManOption.SetActive(false);
            WomanOption.SetActive(false);
        }
    }

    public void ManClick()
    {
        //남자 캐릭터로 바뀌고, 대사도 바뀜 -> text를 두 버전으로 만들어서.. true/false하자..
        
        /*Woman.SetActive(false);
        Man.SetActive(true);
        
        WomanText.SetActive(false);
        ManText.SetActive(true);*/

        SceneManager.LoadScene("Intro_Garam");
    }

    public void WomanClick()
    {
        //여자 캐릭터로 바뀌고, 대사도 바뀜
        /*Man.SetActive(false);
        Woman.SetActive(true);
        
        ManText.SetActive(false);
        WomanText.SetActive(true);*/
        
        SceneManager.LoadScene("Intro_Aseong");
    }
}
