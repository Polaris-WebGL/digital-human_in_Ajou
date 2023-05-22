using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventManager : MonoBehaviour
{
    public AudioClip audioClip;

    void Play()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audioClip = audio.clip;
        audio.PlayOneShot(audioClip, 1.0f);
    }
    public void ButtonClick()
    {
        Play();
        Debug.Log("audio play");
        
        SceneManager.LoadScene("Intro");
    }
}
