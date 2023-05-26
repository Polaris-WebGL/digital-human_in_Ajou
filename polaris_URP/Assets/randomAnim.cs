using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class randomAnim : MonoBehaviour
{
    AudioSource audioData;

    Animator m_Animator;
    void Start()
    {
        //Get the Animator attached to the GameObject you are intending to animate.
        m_Animator = gameObject.GetComponent<Animator>();
        audioData = gameObject.GetComponent<AudioSource>();
    }

    public void startAnim()
    {
        m_Animator.SetBool("startAnim",true);
        
        audioData.Play(0);
        Debug.Log("started");
    }
}
