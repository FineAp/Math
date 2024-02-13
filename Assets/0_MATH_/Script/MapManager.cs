using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    public GameObject player;
    public GameObject[] ground;

    private bool isSand = false;
    private bool isStone = false;
    private bool isMoss = false;
    private bool isDiamond = false;


    void Update()
    {
        LoopMap();
    }


    void LoopMap()
    {
        //sand 부분 생성 및 지우기
        if(player.transform.position.y < -13f && !isSand)
        {
            ground[0].SetActive(false);
            isSand = true;

        }
        else if(player.transform.position.y > -13f && isSand)
        {
            ground[0].SetActive(true);
            isSand = false;
        }
        //ston 부분 생성
        if(player.transform.position.y > -13f && player.transform.position.y < -4f && !isStone)
        {
            ground[1].SetActive(true);
            isStone = true;
            
        } 
        //숨기기
        else if(player.transform.position.y <-22f || player.transform.position.y > -4f && isStone)
        {
            ground[1].SetActive(false);
            isStone = false;
            
        }
        //moss 부분 생성
        if(player.transform.position.y < -13f && !isMoss)
        {
            
            ground[2].SetActive(true);
            isMoss = true;
        }
        else if(player.transform.position.y > -13f && isMoss)
        {
            ground[2].SetActive(false);
            isMoss = false;
        }
        //Dimond 부분 생성
        if(player.transform.position.y < -22f && !isDiamond)
        {
            ground[3].SetActive(true);
            isDiamond = true;
        }
        else if(player.transform.position.y > -22f && isDiamond)
        {
            ground[3].SetActive(false);
            isDiamond = false;
        }

    }

}
