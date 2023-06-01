using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void chkClick(GameObject popup)
    {
        popup.SetActive(true);
    }

    public void ClosePopup(GameObject popPanel)
    {
        popPanel.SetActive(false);
    }

    public void openLink_apply()
    {
        Application.OpenURL("http://paran-polaris.co.kr:8080/club");
    }
    public void openLink_switch()
    {
        Application.OpenURL("https://consult.mncapro.co.kr/solution/ajou/department/index.html");
    }
    public void openLink_map()
    {
        Application.OpenURL("http://www.iajou.ac.kr/ajouvr.jsp");
    }

    /*
     책 팝업 > 사이트 이동
     */
    public void openLinkBook(int n)
    {
        string url = "";
        if(n==11) //중앙도서관
        {
            url = "https://library.ajou.ac.kr/#/";
        }
        else if(n==12) //MOCA
        {
            url = "https://ose.ajou.ac.kr/member/rl/login/loginForm.do";
        }
        else if(n==13) //아주Bb
        {
            url = "https://eclass2.ajou.ac.kr/ultra/course";
        }
        else if(n==21) //아주 허브
        {
            url = "https://hub.ajou.ac.kr/clientMain/a/t/main.do";
        }
        else if (n == 22) //대학교육혁신원
        {
            url = "https://ace.ajou.ac.kr/ace/index.do";
        }
        else if (n == 23) //아주심리상담센터
        {
            url = "http://apcc1721.ajou.ac.kr/apcc1721/index.jsp";
        }
        else if (n == 31) //입학처
        {
            url = "http://www.iajou.ac.kr/main.do";
        }
        else if (n == 32) //대학일자리+센터
        {
            url = "https://job.ajou.ac.kr/main/Default.aspx";
        }
        else if (n == 33) //LINK사업단
        {
            url = "https://linc.ajou.ac.kr/";
        }
        else if (n == 34) //창업지원단
        {
            url = "http://changup.ajou.ac.kr/";
        }
        else if (n == 35) //산학협력단
        {
            url = "http://iacf.ajou.ac.kr/iacf/index.jsp";
        }
        Application.OpenURL(url);
    }
}
