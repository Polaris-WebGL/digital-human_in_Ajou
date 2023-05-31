using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class randomAnim : MonoBehaviour
{
    public Text Dialogue;
    AudioSource audioData;
    Animator m_Animator;
    public bool maleChk = false;
    public AudioClip[] audioArr;

    private string[] fDialogueArray =
    {
        "�� �̸��� ��Ƽ��̾�. ������ �� ��������!",
        "���� ������ �� ����?",
        "���� ���� ����!"
    };

    private string[] mDialogueArray =
    {
        "�� �̸��� �ְ����̾�. ������ �� ��������!",
        "���� ������ �� ����?",
        "���� ���� ����!"
    };

    private int RandomNum;

    void Start()
    {
        //Get the Animator attached to the GameObject you are intending to animate.
        m_Animator = gameObject.GetComponent<Animator>();
        audioData = gameObject.GetComponent<AudioSource>();
    }

    public void startAnim()
    {
        RandomNum = Random.Range(0, 3); //0���� 2���� �����ϰ� �߻�
        Debug.Log(RandomNum);
        m_Animator.SetInteger("random", RandomNum);

        Dialogue.text = fDialogueArray[RandomNum];

        m_Animator.SetBool("pauseAnim", false);
        m_Animator.SetBool("startAnim",true);
        audioData.clip = audioArr[RandomNum];
        //audioData.Play(0);

        if(!maleChk)
        {
            if (RandomNum == 0)
            {
                audioData.Play(0);
            }
            else if (RandomNum == 1)
            {
                Invoke("playAudio", 1.5f);
            }else if (RandomNum == 2)
            {
                Invoke("playAudio", 0.6f);
            }
        }
        
        //m_Animator.SetBool("pauseAnim", true);

    }
    private void playAudio()
    {
        audioData.Play(0);
    }
}
