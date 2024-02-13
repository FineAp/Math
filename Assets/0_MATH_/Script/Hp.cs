using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hp : MonoBehaviour
{
    public Player player;
    public GameObject[] hpZip;
    public GameObject quiz;
    public GameObject dieUI;
    public int hp = 4;

    public void NoGood()
    {
        hp -= 1;
        
        hpZip[hp].SetActive(false);
        quiz.SetActive(false);

        if(hp == 0)
        {
            dieUI.SetActive(true);
            player.speed = 0f;
        }
    }

}
