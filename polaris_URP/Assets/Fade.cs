using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Fade : MonoBehaviour

{
    public float animTime = 2f;         // Fade �ִϸ��̼� ��� �ð� (����:��).  
    private Image fadeImage;            // UGUI�� Image������Ʈ ���� ����.  

    private float start = 1f;           // Mathf.Lerp �޼ҵ��� ù��° ��.  
    private float end = 0f;             // Mathf.Lerp �޼ҵ��� �ι�° ��.  
    private float time = 0f;            // Mathf.Lerp �޼ҵ��� �ð� ��.  


    public bool stopIn = false; //false�϶� ����Ǵ°ǵ�, �ʱⰪ�� false�� �� ������ ���� �����Ҷ� ���̵������� ������...�װ� ������ true�� �ϸ��.
    public bool stopOut = false;
    private bool stopOutchk = false;

    void Awake()
    {
        // Image ������Ʈ�� �˻��ؼ� ���� ���� �� ����.  
        fadeImage = GetComponent<Image>();
    }

    void Start()
    {
       // m_Animator = gameObject.GetComponent<Animator>();
        //audioData = gameObject.GetComponent<AudioSource>();
        //Invoke("startAnim", 0.05f);
        //Invoke("playAudio", 0.05f);
        Invoke("OnInvoke", 10.5f);
        
    }
    void OnInvoke()
    {
        if (stopOut == false)
        {
            stopOutchk = true;
            Debug.Log("Fadeout");
        }
    }

    void Update()
    {

        // ���������� = FadeIn �ִϸ��̼� ���.  
        if (stopIn == false && time <= 2)
        {
            PlayFadeIn();
        }
        if (stopOut == false && time <= 2 && stopOutchk==true)
        {
            PlayFadeOut();
        }
        if (time >= 2 && stopIn == false)
        {
            stopIn = true;
            time = 0;
            Debug.Log("StopIn");
        }
        if (time >= 2 && stopOut == false)
        {
            stopIn = false; //�Ͼ�� ��ȯ�ǰ� ���� �� ��ȯ �� �ٽ� Ǯ�Ŷ� �־���. �׳� ���� �����Ÿ� ���� �ʿ� ����.
            stopOut = true;
            time = 0;
            Debug.Log("StopOut");
        }

    }

    // ���->����
    void PlayFadeIn()
    {
        // ��� �ð� ���.  
        // 2��(animTime)���� ����� �� �ֵ��� animTime���� ������.  
        time += Time.deltaTime / animTime;

        // Image ������Ʈ�� ���� �� �о����.  
        Color color = fadeImage.color;
        // ���� �� ���.  
        color.a = Mathf.Lerp(start, end, time);
        // ����� ���� �� �ٽ� ����.  
        fadeImage.color = color;
        // Debug.Log(time);
    }

    // ����->���
    void PlayFadeOut()
    {
        // ��� �ð� ���.  
        // 2��(animTime)���� ����� �� �ֵ��� animTime���� ������.  
        time += Time.deltaTime / animTime;

        // Image ������Ʈ�� ���� �� �о����.  
        Color color = fadeImage.color;
        // ���� �� ���.  
        color.a = Mathf.Lerp(end, start, time);  //FadeIn���� �޸� start, end�� �ݴ��.
        // ����� ���� �� �ٽ� ����.  
        fadeImage.color = color;
    }

}