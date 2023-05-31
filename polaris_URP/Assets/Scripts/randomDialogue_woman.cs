using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class randomDialogue_woman : MonoBehaviour
{
    public Text Dialogue;
    public AudioClip[] audioArr;
    public GameObject digitahHuman;

    private string[] DialogueArray =
    {
        "내 이름은 장아성이야. 앞으로 잘 지내보자!",
        "오늘 점심은 뭐 먹지?",
        "오늘 날씨 좋다!"
    };

    private int RandomNum;
    
    public void Start()
    {
        //RandomNum = Random.Range(0,3); //0부터 8까지 랜덤하게 발생
        //Debug.Log(RandomNum);

        //Dialogue.text = DialogueArray[RandomNum];
    }

    void Update()
    {
        if (RandomNum == 0)
        {
            //해당 텍스트 음성
            //digitahHuman.GetComponent<AudioSource>().clip = audioArr[RandomNum];
            //digitahHuman.GetComponent<AudioSource>().Play();
        }
        else if (RandomNum == 1)
        {
            //해당 텍스트 음성
            //digitahHuman.GetComponent<AudioSource>().clip = audioArr[RandomNum];
        }
        else if (RandomNum == 2)
        {
            //해당 텍스트 음성
            //digitahHuman.GetComponent<AudioSource>().clip = audioArr[RandomNum];
        }
    }
}
