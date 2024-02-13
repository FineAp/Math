using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    
    public bool canEnter = false;
    public bool canEnter2 = false;
    public bool canOutShop = false;
    public bool canOutFly = false;

    public void ToGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void ToStory()
    {
        SceneManager.LoadScene("Story");
    }


    void OnTriggerStay2D(Collider2D others)
    {
        if(others.gameObject.CompareTag("Shop_one"))
        {
            canEnter = true;

            // print(canEnter);
        }

        if(others.gameObject.CompareTag("Shop_two"))
        {
            canEnter2 = true;

        }

        else if(others.gameObject.CompareTag("ShopDoor"))
        {
            canOutShop = true;

        }

        else if (others.gameObject.CompareTag("FlyDoor"))
        {
            canOutFly = true;

        }        

    }

    void OnTriggerExit2D(Collider2D others)
    {
        if(others.gameObject.CompareTag("Shop_one"))
        {
            canEnter = false;

            // print(canEnter);
        }

        if(others.gameObject.CompareTag("Shop_two"))
        {
            canEnter2 = false;

        }

        else if(others.gameObject.CompareTag("ShopDoor"))
        {
            canOutShop = false;

        }

        else if (others.gameObject.CompareTag("FlyDoor"))
        {
            canOutFly = false;

        }

    }



}
