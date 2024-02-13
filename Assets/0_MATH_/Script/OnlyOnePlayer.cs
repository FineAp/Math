using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnlyOnePlayer : MonoBehaviour
{
    private static OnlyOnePlayer instance; // 플레이어 매니저의 싱글톤 인스턴스
    public GameObject player; // 플레이어 게임 오브젝트

    private void Awake()
    {
        // PlayerManager의 싱글톤 인스턴스 설정
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject); // 이미 다른 PlayerManager가 존재하면 현재 오브젝트 파괴
            return;
        }

        // 플레이어 게임 오브젝트 생성 또는 유지
        if (player == null)
        {
            player = InstantiatePlayer();
            DontDestroyOnLoad(player);
        }
    }

    private GameObject InstantiatePlayer()
    {
        if (player == null)
        {
            player = GameObject.Find("Player"); // 씬에서 "Player"라는 이름의 게임 오브젝트를 찾아서 할당

        }
        return player;
    }
}
