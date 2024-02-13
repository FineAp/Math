using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NPC : MonoBehaviour
{
    public List<GameObject> storys = new List<GameObject>();
    public Shop shop;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //*if i have items i can change story*
            
            if (shop.haveStar) storys[1].SetActive(true);
            else if (shop.haveWater) storys[2].SetActive(true);
            else if (shop.havePoison) storys[3].SetActive(true);
            else if (shop.haveCrystal) storys[4].SetActive(true);
            else if (shop.haveGhost) storys[5].SetActive(true);
            else if (shop.haveAngel) storys[6].SetActive(true);
            else if (shop.haveBear) storys[7].SetActive(true);
            else if (shop.haveDevil) storys[8].SetActive(true);

 
            else storys[0].SetActive(true);


        }

    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            storys[0].SetActive(false);
            storys[1].SetActive(false);
            storys[2].SetActive(false);
            storys[3].SetActive(false);
            storys[4].SetActive(false);
            storys[5].SetActive(false);
            storys[6].SetActive(false);
            storys[7].SetActive(false);
            storys[8].SetActive(false);
            // storys[9].SetActive(false); //Clear talk.

        }
    }

}
