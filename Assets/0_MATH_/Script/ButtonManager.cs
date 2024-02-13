using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonManager : MonoBehaviour
{
    
    public GameObject inventory;
    public GameObject myBagOpen;

    public SceneManage scene;
    public Player player;

    
    private int count = 0;

    public void House()
    {
        player.isResetPos = true;
        
    }


    public void Back()
    {
        inventory.SetActive(false);
    }

    public void MyBagOpen()
    {

        if(count == 0)
        {
            myBagOpen.SetActive(true);
            count++;
        }
        else if(count == 1)
        {
            myBagOpen.SetActive(false);
            count = 0;
        }

    }

    public void EnterShop()
    {
        print("Click Shop");
        if(scene.canEnter)
        {
            player.frontShop = true;
            print("A");

        }

        if(scene.canEnter2)
        {
            //개구리샵에 들어갈 떄 
            player.frontFly = true;
        }

        if(scene.canOutShop)
        {
            player.outShop = true;
        }
        
        if(scene.canOutFly)
        {
            player.outFly = true;

        }
        
        Invoke("CantEnter", 0.2f);
        
    
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Story");

    }

    public void GameWin()
    {
        SceneManager.LoadScene("Clear");

    }

    void CantEnter()
    {
        scene.canEnter = false;
        scene.canEnter2 = false;
        scene.canOutShop = false;
        scene.canOutFly = false;

        print(scene.canEnter);
        print(scene.canEnter2);

    }
}
