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
    public void openLink_book1(GameObject obj)
    {
        //ClosePopup(obj);
        Application.OpenURL("http://www.iajou.ac.kr/main.do");            
    }
    public void openLink_book3(GameObject obj)
    {
        ClosePopup(obj);
        Application.OpenURL("https://www.ajou.ac.kr/oia/index.do");            
    }
    public void openLink_book4(GameObject obj)
    {
        ClosePopup(obj);
        Application.OpenURL("https://moca.ajou.ac.kr");            
    }
    public void openLink_book5(GameObject obj)
    {
        ClosePopup(obj);
        Application.OpenURL("https://job.ajou.ac.kr/");            
    }
    public void openLink_book6(GameObject obj)
    {
        ClosePopup(obj);
        Application.OpenURL("https://www.ajou.ac.kr/iadmissions/index.do");            
    }
    public void openLink_book7(GameObject obj)
    {
        ClosePopup(obj);
        Application.OpenURL("https://hub.ajou.ac.kr/clientMain/a/t/main.do");            
    }
}
