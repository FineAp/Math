using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnMove : MonoBehaviour
{
    public GameManager gameManager;
    public Ex ex;

    GameObject player;
    Player playerMove;
    
    Collider2D playerCollider;

    public float colliderOffset = 0.1f;

    private Animator anim;

    void Start()
    {
        player = GameObject.Find("Player");
        playerMove = player.GetComponent<Player>();

        playerCollider = player.GetComponent<Collider2D>();

        anim = player.GetComponentInChildren<Animator>();
        
    }

    public void LeftBtnDown()
    {
        playerMove.LeftMove = true;
        playerMove.isIdle = false;

    }
    public void LeftBtnUp()
    {
        playerMove.LeftMove = false;
        playerMove.isIdle = true;
    }

    public void RightBtnDown()
    {
        playerMove.RightMove = true;
        playerMove.isIdle = false;

    }
    public void RightBtnUp()
    {
        playerMove.RightMove = false;
        playerMove.isIdle = true;
    }
        
    public void UpBtnDown()
    {
        playerMove.PlayerJump = true;
        playerMove.isIdle = false;

    }
        
    public void UpBtnUp()
    {
        playerMove.PlayerJump = false;
        playerMove.isIdle = true;


    }
    public void DownBtnDown()
    {
        playerMove.Add = true;
        
        ex.isChange = false;
        ex.isStopChange = false;

        ex.a = 0;
        ex.b = 0;
        ex.c = 0;
    }

    public void DownBtnUp()
    {
        playerMove.Add = false;
        //블럭들 변수 false 해주는 구역
        playerMove.isGrass = false;
        playerMove.isSand = false;
        playerMove.isStone = false;
        playerMove.isMoss = false;
        playerMove.isDiamond = false;


    }

    public void Answers()
    {
        gameManager.setActiveLevelOne.SetActive(false);
        playerMove.get_coin = true;


    }
    public void WrongAnswer()
    {
        gameManager.setActiveLevelOne.SetActive(false);
    }


    
}
