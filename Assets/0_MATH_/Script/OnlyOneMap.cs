using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnlyOneMap : MonoBehaviour
{
    private static OnlyOneMap instance; // 플레이어 매니저의 싱글톤 인스턴스
    
    private GameObject Ui; // 플레이어 게임 오브젝트
    private GameObject RunTime;
    private GameObject Objs;
    private void Awake()
    {
        // PlayerManager의 싱글톤 인스턴스 설정
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); // 이미 다른 PlayerManager가 존재하면 현재 오브젝트 파괴
            return;
        }

        // 플레이어 게임 오브젝트 생성 또는 유지
        if (Ui == null)
        {
            Ui = FindObjectByName("---UI---");
            DontDestroyOnLoad(Ui);
        }

        if (RunTime == null)
        {
            RunTime = FindObjectByName("---RUNTIME---");
            DontDestroyOnLoad(RunTime);
        }

        if (Objs == null)
        {
            Objs = FindObjectByName("---OBJECT---");
            DontDestroyOnLoad(Objs);
        }
    }

    private GameObject FindObjectByName(string objectName)
    {
        GameObject foundObject = GameObject.Find(objectName);
        if (foundObject == null)
        {
            Debug.LogError("Cannot find object with name: " + objectName);
        }
        return foundObject;
    }
}
