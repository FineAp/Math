using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterSide : MonoBehaviour
{
    public float rotSpeed = 50f;

    private float posZ;
    private bool isRot = false;

    // Update is called once per frame
    void Update()
    {
        if(isRot)
        {
            transform.rotation = Quaternion.Euler(0f,0f,90f );
        }
        else
        {
            transform.rotation = Quaternion.Euler(0f,0f, 0f);

        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.gameObject.CompareTag("Player"))
        {
           isRot = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            isRot = false;
        }
    }
}
