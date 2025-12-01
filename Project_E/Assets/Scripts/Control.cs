using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Control : MonoBehaviour
{
    public int a;
    public int b;
    public string fruit;

    void Start()
    {
        /*
        if (a > b)
        {
            Debug.Log("a 가 b 보다 큽니다");
        }
        else if (a < b)
        {
            Debug.Log("a 가 b 보다 크지 않습니다");
        }
        else
        {
            Debug.Log("a 와 b 는 같습니다.");
        }

        // switch 문을 Start() 메서드 안으로 이동
        switch (this.fruit)
        {
            case "사과":
                Debug.Log("사과는 빨갛습니다.");
                break;
            case "바나나":
                Debug.Log("바나나는 노랗습니다.");
                break;
            case "포도":
                Debug.Log("포도는 보라색입니다.");
                break;
            default:
                Debug.Log("알 수 없는 과일입니다.");
                break;
        }

        for (int i = 0; i < 5; i++)
        {
            Debug.Log("i 의 값: " +  i);
        }

        while (a < 10)
        {
            Debug.Log("a 의 값: " + a);
            a++;
        }
        do
        {
            Debug.Log("b 의 값: " + b);
            b--;

        } while (b > 0); 
    */

        string[] array = new string[5];

        array[0] = "강대원";
        array[1] = "민영희";
        array[2] = "박두팔";
        array[3] = "안선생";
        array[4] = "함수빈";
        array[5] = "오정수";

        for(int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        int[] scores = { 90, 85, 78, 92, 88 };
        int[] arr2 = new int[3];
        }

    void Update()
    {

    }
}