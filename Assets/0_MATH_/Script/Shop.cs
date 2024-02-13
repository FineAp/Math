using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public Player forCoin;
    public Hp  hp;

    public GameObject Inven;
    public GameObject[] getItem;
    

    public bool haveStar = false;
    public bool haveWater = false;
    public bool havePoison = false;
    public bool haveCrystal = false;
    public bool haveGhost = false;
    public bool haveAngel = false;
    public bool haveBear = false;
    public bool haveDevil = false;

    private bool closeShop = false;


    void OnCollisionStay2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player") && !closeShop)
        {
            Inven.SetActive(true);
            closeShop = true;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Inven.SetActive(false);
            closeShop = false;
        }
    }

    public void Star()
    {
        if (forCoin.coin >= 10 && !haveStar)
        {
            forCoin.coin -= 10;

            getItem[0].SetActive(true);

            getItem[1].SetActive(false);
            getItem[2].SetActive(false);
            getItem[3].SetActive(false);
            getItem[4].SetActive(false);
            getItem[5].SetActive(false);
            getItem[6].SetActive(false);
            getItem[7].SetActive(false);

            haveStar = true;

            haveWater = false;
            havePoison = false;
            haveCrystal = false;
            haveGhost = false;
            haveAngel = false;
            haveBear = false;
            haveDevil = false;

            for (int i = 0; i < 4; i++)
            {
                hp.hpZip[i].SetActive(true);
            }

            hp.hp = 4;
        
        }
    }

    public void Water()
    {
        if(forCoin.coin >= 30 && !haveWater)
        {
            forCoin.coin -= 30;

            getItem[1].SetActive(true);

            getItem[0].SetActive(false);
            getItem[2].SetActive(false);
            getItem[3].SetActive(false);
            getItem[4].SetActive(false);
            getItem[5].SetActive(false);
            getItem[6].SetActive(false);
            getItem[7].SetActive(false);

            haveWater = true;

            haveStar = false;
            havePoison = false;
            haveCrystal = false;
            haveGhost = false;
            haveAngel = false;
            haveBear = false;
            haveDevil = false;

            for (int i = 0; i < 4; i++)
            {
                hp.hpZip[i].SetActive(true);
            }

            hp.hp = 4;
        }
    }

    public void Poison()
    {
        if(forCoin.coin >= 50 && !havePoison)
        {
            forCoin.coin -= 50;

            getItem[2].SetActive(true);

            getItem[0].SetActive(false);
            getItem[1].SetActive(false);
            getItem[3].SetActive(false);
            getItem[4].SetActive(false);
            getItem[5].SetActive(false);
            getItem[6].SetActive(false);
            getItem[7].SetActive(false);

            havePoison = true;

            haveStar = false;
            haveWater = false;
            haveCrystal = false;
            haveGhost = false;
            haveAngel = false;
            haveBear = false;
            haveDevil = false;

            for (int i = 0; i < 4; i++)
            {
                hp.hpZip[i].SetActive(true);
            }

            hp.hp = 4;
        }
    }

    public void Crystal()
    {
        if(forCoin.coin >= 70 && !haveCrystal)
        {
            forCoin.coin -= 70;

            getItem[3].SetActive(true);

            getItem[0].SetActive(false);
            getItem[1].SetActive(false);
            getItem[2].SetActive(false);
            getItem[4].SetActive(false);
            getItem[5].SetActive(false);
            getItem[6].SetActive(false);
            getItem[7].SetActive(false);

            haveCrystal = true;

            haveStar = false;
            haveWater = false;
            havePoison = false;
            haveGhost = false;
            haveAngel = false;
            haveBear = false;
            haveDevil = false;

            for (int i = 0; i < 4; i++)
            {
                hp.hpZip[i].SetActive(true);
            }

            hp.hp = 4;
        }
    }

    public void Ghost()
    {
        if(forCoin.coin >= 100 && !haveGhost)
        {

            forCoin.coin -= 100;

            getItem[4].SetActive(true);

            getItem[0].SetActive(false);
            getItem[1].SetActive(false);
            getItem[2].SetActive(false);
            getItem[3].SetActive(false);
            getItem[5].SetActive(false);
            getItem[6].SetActive(false);
            getItem[7].SetActive(false);

            haveGhost = true;

            haveStar = false;
            haveWater = false;
            havePoison = false;
            haveCrystal = false;
            haveAngel = false;
            haveBear = false;
            haveDevil = false;

            for (int i = 0; i < 4; i++)
            {
                hp.hpZip[i].SetActive(true);
            }

            hp.hp = 4;
        }
    }

    public void Angel()
    {
        if(forCoin.coin >= 150 && !haveAngel)
        {
            forCoin.coin -= 150;

            getItem[5].SetActive(true);

            getItem[0].SetActive(false);
            getItem[1].SetActive(false);
            getItem[2].SetActive(false);
            getItem[3].SetActive(false);
            getItem[4].SetActive(false);
            getItem[6].SetActive(false);
            getItem[7].SetActive(false);

            haveAngel = true;

            haveStar = false;
            haveWater = false;
            havePoison = false;
            haveCrystal = false;
            haveGhost = false;
            haveBear = false;
            haveDevil = false;

            for (int i = 0; i < 4; i++)
            {
                hp.hpZip[i].SetActive(true);
            }

            hp.hp = 4;
        }
    }

    public void Bear()
    {
        if(forCoin.coin >= 180 && !haveBear)
        {
            forCoin.coin -= 180;

            getItem[6].SetActive(true);

            getItem[0].SetActive(false);
            getItem[1].SetActive(false);
            getItem[2].SetActive(false);
            getItem[3].SetActive(false);
            getItem[4].SetActive(false);
            getItem[5].SetActive(false);
            getItem[7].SetActive(false);

            haveBear = true;

            haveStar = false;
            haveWater = false;
            havePoison = false;
            haveCrystal = false;
            haveGhost = false;
            haveAngel = false;
            haveDevil = false;

            for (int i = 0; i < 4; i++)
            {
                hp.hpZip[i].SetActive(true);
            }

            hp.hp = 4;
        }
    }

    public void Devil()
    {
        if(forCoin.coin >= 200 && !haveDevil)
        {
            forCoin.coin -= 200;

            getItem[7].SetActive(true);

            getItem[0].SetActive(false);
            getItem[1].SetActive(false);
            getItem[2].SetActive(false);
            getItem[3].SetActive(false);
            getItem[4].SetActive(false);
            getItem[5].SetActive(false);
            getItem[6].SetActive(false);

            haveDevil = true;

            haveStar = false;
            haveWater = false;
            havePoison = false;
            haveCrystal = false;
            haveGhost = false;
            haveAngel = false;
            haveBear = false;

            for (int i = 0; i < 4; i++)
            {
                hp.hpZip[i].SetActive(true);
            }

            hp.hp = 4;
        }
    }
}
