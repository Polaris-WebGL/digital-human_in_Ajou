using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class animationControl_woman : MonoBehaviour
{
    AudioSource audioData;
    Animator m_Animator;
    public GameObject DigitalH;

    void Start()
    {
        m_Animator = DigitalH.GetComponent<Animator>();
        audioData = gameObject.GetComponent<AudioSource>();
        Invoke("startAnim", 0.4f);
        audioData.Play(0);
        Invoke("OnInvoke", 11.0f);
        //this.GetComponent<Animator>().Play();
    }
    void OnInvoke()
    {
        Debug.Log("11�� �� Ivoke �ߵ�");
        SceneManager.LoadScene("Room_Aseong");
    }
    void playAudio()
    {
        audioData.Play(0);
        Debug.Log("started");
    }
    public void startAnim()
    {
        DigitalH.SetActive(true);
        //m_Animator.SetBool("startAnim", true);
    }
}
