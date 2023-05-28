using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class animationControl_man : MonoBehaviour
{
    AudioSource audioData;
    Animator m_Animator;

    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
        audioData = gameObject.GetComponent<AudioSource>();
        Invoke("startAnim", 0.05f);
        Invoke("playAudio", 0.05f);
        Invoke("OnInvoke", 11.5f);
        //this.GetComponent<Animator>().Play();
    }
    void OnInvoke()
    {
        Debug.Log("11�� �� Ivoke �ߵ�");
        SceneManager.LoadScene("Room_Garam");
    }
    void playAudio()
    {
        audioData.Play(0);
        Debug.Log("started");
    }
    public void startAnim()
    {
        m_Animator.SetBool("startAnim", true);
    }
}
