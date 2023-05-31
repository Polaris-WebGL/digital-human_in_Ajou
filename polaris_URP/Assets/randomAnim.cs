using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class randomAnim : MonoBehaviour
{
    public Text Dialogue;
    AudioSource audioData;
    Animator m_Animator;
    public bool maleChk;
    public AudioClip[] audioArr;

    private string[] fDialogueArray =
    {
        "내 이름은 장아성이야. 앞으로 잘 지내보자!",
        "오늘 점심은 뭐 먹지?",
        "오늘 날씨 좋다!"
    };

    private string[] mDialogueArray =
    {
        "내 이름은 최가람이야. 앞으로 잘 지내보자!",
        "오늘 점심은 뭐 먹지?",
        "오늘 날씨 좋다!"
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
        RandomNum = Random.Range(0, 3); //0부터 2까지 랜덤하게 발생
        Debug.Log(RandomNum);
        m_Animator.SetInteger("random", RandomNum);

        Dialogue.text = fDialogueArray[RandomNum];

        m_Animator.SetBool("startAnim",true);
        audioData.clip = audioArr[RandomNum];
        audioData.Play(0);

        m_Animator.SetBool("pauseAnim", true);

    }
}
