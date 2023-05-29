using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class randomDialogue_woman : MonoBehaviour
{
    public Text Dialogue;

    private string[] DialogueArray =
    {
        "안녕! 너가 내 룸메구나~ 어서 와ㅎㅎ",
        "나는 책상에 앉아 있을 테니까 편하게 둘러봐~",
        "내 이름은 장아성이야. 앞으로 잘 지내보자!",
        "배고프다..",
        "너는 무슨 과야?",
        "오늘 점심은 뭐 먹지?",
        "방 구경은 잘 하고 있어?",
        "오늘 날씨 좋다!",
        "너랑 룸메가 되어서 너무 좋다!"
    };

    private int RandomNum;
    
    public void Start()
    {
        RandomNum = Random.Range(0, 9); //0부터 8까지 랜덤하게 발생
        Debug.Log(RandomNum);

        Dialogue.text = DialogueArray[RandomNum];
    }

    void Update()
    {
        if (RandomNum == 0)
        {
            //해당 텍스트 음성
        }
        else if (RandomNum == 1)
        {
            //해당 텍스트 음성
        }
        else if (RandomNum == 2)
        {
            //해당 텍스트 음성
        }
        else if (RandomNum == 3)
        {
            //해당 텍스트 음성
        }
        else if (RandomNum == 4)
        {
            //해당 텍스트 음성
        }
        else if (RandomNum == 5)
        {
            //해당 텍스트 음성
        }
        else if (RandomNum == 6)
        {
            //해당 텍스트 음성
        }
        else if (RandomNum == 7)
        {
            //해당 텍스트 음성
        }
        else if (RandomNum == 8)
        {
            //해당 텍스트 음성
        }
    }
}
