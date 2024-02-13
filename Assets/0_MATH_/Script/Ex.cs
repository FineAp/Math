using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex : MonoBehaviour
{
    public GameObject target_a;
    public GameObject target_b;
    public GameObject target_c;

    public List<GameObject> numbers  = new List<GameObject>();

    public bool isChange = false;
    public bool isStopChange = false;

    public int a;
    public int b;
    public int c;
    
    void Update()
    {
        if(a!=b && a!=c && b!=c) //인덱스 값이 겹치지 않을 경우 Target으로 이동.
        {
            isChange = true; //인덱스 값이 겹치지 않으면  abc 숫자값을 변경하지 않도록 하기 위함

            if(isChange && !isStopChange) 
            {
                numbers[a].transform.position = target_a.transform.position;
                numbers[b].transform.position = target_b.transform.position;
                numbers[c].transform.position = target_c.transform.position;
                
                print("다 다르다.");
                isStopChange = true;
            }

        }

        else
        {
            if(!isChange)
            {
                a = Random.Range(0, 3);
                b = Random.Range(0, 3);
                c = Random.Range(0, 3);

                print(a);
                print(b);
            }
            
        }

    }
}

