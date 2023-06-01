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
     å �˾� > ����Ʈ �̵�
     */
    public void openLinkBook(int n)
    {
        string url = "";
        if(n==11) //�߾ӵ�����
        {
            url = "https://library.ajou.ac.kr/#/";
        }
        else if(n==12) //MOCA
        {
            url = "https://ose.ajou.ac.kr/member/rl/login/loginForm.do";
        }
        else if(n==13) //����Bb
        {
            url = "https://eclass2.ajou.ac.kr/ultra/course";
        }
        else if(n==21) //���� ���
        {
            url = "https://hub.ajou.ac.kr/clientMain/a/t/main.do";
        }
        else if (n == 22) //���б������ſ�
        {
            url = "https://ace.ajou.ac.kr/ace/index.do";
        }
        else if (n == 23) //���ֽɸ���㼾��
        {
            url = "http://apcc1721.ajou.ac.kr/apcc1721/index.jsp";
        }
        else if (n == 31) //����ó
        {
            url = "http://www.iajou.ac.kr/main.do";
        }
        else if (n == 32) //�������ڸ�+����
        {
            url = "https://job.ajou.ac.kr/main/Default.aspx";
        }
        else if (n == 33) //LINK�����
        {
            url = "https://linc.ajou.ac.kr/";
        }
        else if (n == 34) //â��������
        {
            url = "http://changup.ajou.ac.kr/";
        }
        else if (n == 35) //�������´�
        {
            url = "http://iacf.ajou.ac.kr/iacf/index.jsp";
        }
        Application.OpenURL(url);
    }
}
