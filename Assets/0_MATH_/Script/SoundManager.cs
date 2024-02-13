using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public GameObject shop;
    public GameObject shop2;
    public GameObject bgm;

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.CompareTag("ShopSM"))
        {
            shop.SetActive(true);
            bgm.SetActive(false);

        }
        if(other.CompareTag("FlySM"))
        {
            shop2.SetActive(true);
            bgm.SetActive(false);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        shop.SetActive(false);
        shop2.SetActive(false);

        bgm.SetActive(true);
    }
}
