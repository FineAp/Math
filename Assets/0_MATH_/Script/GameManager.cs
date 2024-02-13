using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text Level_1_Qution;
    public Text[] Level_1_Ask;

    public GameObject[] Bt_ans; 

    public GameObject setActiveLevelOne;

    //Coin Text
    public Text coinTex;

    //클래스 선언
    public Player playerClass;
    private GameObject otherPlayer;
    private string currentSceneName;

    //HP, Die
    public GameObject[] hps;
    public float hpCount = 4;

    void Update()
    {
        CoinTex();
        // //Game씬으로 되돌아 왔을 경우 player 삭제
        // otherPlayer = GameObject.Find("Player");
        // currentSceneName = Application.loadedLevelName;
        
        // if(currentSceneName == "Game")
        // {
        //     Destroy(otherPlayer);
        // }

    }

    public void Pluss()
    {
        int a = Random.Range(15,30);
        int b = Random.Range(1, 15);

        int c = a + b;

        int ask_1 = Random.Range(1, 15);
        int ask_2 = Random.Range(15, 30);

        if(c == ask_1 || c == ask_2)
        {
            ask_1++;
            ask_2++;
        }

        Level_1_Ask[0].text = ask_1.ToString();
        Level_1_Ask[1].text = ask_2.ToString();
        Level_1_Ask[2].text = c.ToString();

        Level_1_Qution.text = string.Format("{0} + {1} = ", a, b);

        setActiveLevelOne.SetActive(true);
    }    
    // {

    //     //랜덤 숫자 [ 보기 ]
    //     int a = Random.Range(1, 10);
    //     int b = Random.Range(10,20);

    //     int c = a + b;

    //     //문제 랜덤
    //     int ask_1 = Random.Range(2, 15);
    //     int ask_2 = Random.Range(16, 30);

    //     //문제와 답이 같은 경우
    //     if(c == ask_1 || c == ask_2)
    //     {
    //         ask_1++;
    //         ask_2++;
    //     }
    //      // 랜덤으로 정답 위치를 선정
    //     int correctAnswerPosition = Random.Range(0, 3);

    //     for (int i = 0; i < 3; i++)
    //     {
    //         if (i == correctAnswerPosition)
    //         {
    //             Level_1_Ask[i].text = c.ToString();
    //         }

    //         else
    //         {
    //             //오답을 랜덤하게 배치
    //             int randomWrongAnswer = Random.Range(1, 50); // 임의의 오답 생성
    //             while (randomWrongAnswer == c || randomWrongAnswer == ask_1 || randomWrongAnswer == ask_2)
    //             {
    //                 // 생성된 오답이 정답 또는 다른 오답과 겹치면 다시 생성
    //                 randomWrongAnswer = Random.Range(1, 50);
    //             }
    //             Level_1_Ask[i].text = randomWrongAnswer.ToString(); // 오답 배치
    //         }
    //     }

    //     //질문
    //     Level_1_Qution.text = string.Format("{0} + {1} = ", a, b);

    //     setActiveLevelOne.SetActive(true);       
    
    // }
    
    public void Minuss()
    {
        int a = Random.Range(15,30);
        int b = Random.Range(1, 15);

        int c = a - b;

        int ask_1 = Random.Range(1, 15);
        int ask_2 = Random.Range(15, 30);

        if(c == ask_1 || c == ask_2)
        {
            ask_1++;
            ask_2++;
        }

        Level_1_Ask[0].text = ask_1.ToString();
        Level_1_Ask[1].text = ask_2.ToString();
        Level_1_Ask[2].text = c.ToString();

        Level_1_Qution.text = string.Format("{0} - {1} = ", a, b);

        setActiveLevelOne.SetActive(true);
    }

    public void Multiple()
    {
        int a = Random.Range(10, 20);
        int b = Random.Range(1, 20);

        int c = a * b;

        int ask_1 = Random.Range(10, 20);
        int ask_2 = Random.Range(20, 40);

        if(c == ask_1 || c == ask_2)
        {
            ask_1++;
            ask_2++;
        }

        Level_1_Ask[0].text = ask_1.ToString();
        Level_1_Ask[1].text = ask_2.ToString();
        Level_1_Ask[2].text = c.ToString();

        Level_1_Qution.text = string.Format("{0} X {1} = ", a, b);

        setActiveLevelOne.SetActive(true);
    }
    
    public void ThreeNumber_Add_Mulity()
    {
        int a = Random.Range(1, 50);
        int b = Random.Range(1, 50);
        int c = Random.Range(1, 10);
        
        int d = a + b * c;

        int ask_1 = Random.Range(2,50);
        int ask_2 = Random.Range(50,100);

        Level_1_Ask[0].text = ask_1.ToString();
        Level_1_Ask[1].text = ask_2.ToString();
        Level_1_Ask[2].text = d.ToString();

        Level_1_Qution.text = string.Format("{0} + {1} * {2} = ", a,b,c);

        setActiveLevelOne.SetActive(true);
    }

    public void Divide()
    {
        int a = Random.Range(10, 50);
        List<int> divisors = FindDivisors(a);

        int b = divisors[Random.Range(0, divisors.Count)];
        
        int c = a / b;

        Level_1_Ask[0].text = a.ToString();
        Level_1_Ask[1].text = b.ToString();
        Level_1_Ask[2].text = c.ToString();

        Level_1_Qution.text = string.Format("{0} % {1} = ", a,b);

        setActiveLevelOne.SetActive(true);

    }
    
    public List<int> FindDivisors(int number)
    {
        List<int> divisors = new List<int>();

        for (int i = 1; i<= number; i++)
        {
            if(number % 1== 0)
            {
                divisors.Add(i);
            }
        }
        return divisors;
    }

    public void CoinTex()
    {
        coinTex.text = playerClass.coin.ToString();

    }

    public void Die()
    {
        

    }



}
