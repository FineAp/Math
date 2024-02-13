using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    //상점 문 앞으로 위치 이동.
    public GameObject targetPosShop;
    public GameObject targetPosFly;

    public bool frontShop = false;
    public bool frontFly = false;

    //상점 나갈 때 위치 이동
    public GameObject targetPosShopOut;
    public GameObject targetPosFlyOut;

    public bool outShop = false;
    public bool outFly = false;

    //클래스 사용
    public GameManager gameManager;
    public Items item;

    public bool LeftMove = false;
    public bool RightMove = false;
    public bool PlayerJump = false;
    public bool PlayerDown = false;
    public bool Add = false;
    

    public bool isIdle = false;
    public bool canJump = true;

    

    Vector3 moveVelocity = Vector3.zero;

    public float speed;
    public float jump = 10f;

    private Animator anim;
    private SpriteRenderer render;
    private Rigidbody2D rb;
    //Drop Coin
    public int coin = 0;

    //블럭에 닿을경우들
    public bool isGrass = false;
    public bool isSand = false;
    public bool isStone = false;
    public bool isMoss = false;
    public bool isDiamond = false;


    //블럭이 작아지기 위함
    public bool get_coin = false;

    //제자리 이동
    public bool isResetPos = false;
    private Vector2 startPos;

    //작은 블럭을 생성하기 위함
    public GameObject[] Coins;

    public bool isFixAirplan = false;


    void Start()
    {
        render = GetComponent<SpriteRenderer>();
        anim = GetComponentInChildren<Animator>();

        rb = GetComponent<Rigidbody2D>();

        startPos = transform.position;
    }

    void Update()
    {
        Move();
        Choice();
        ResetPos();
        InShop();
        OutShop();

        if(PlayerJump && canJump)
        {
            Jump();
            canJump = false;
        }


    }

    void InShop()
    {
        if(frontShop)
        {
            transform.position = targetPosShop.transform.position;
            frontShop = false;
        }

        else if(frontFly)
        {
            transform.position = targetPosFly.transform.position;
            frontFly = false;
        }
    }

    void OutShop()
    {
        if(outShop)
        {
            transform.position = targetPosShopOut.transform.position;
            outShop = false;
            print("연결완료");
        }

        else if(outFly)
        {
            transform.position = targetPosFlyOut.transform.position;
            outFly = false;
        }
    }

    void ResetPos()
    {
        if(isResetPos)
        {
            transform.position = startPos;
            isResetPos = false;
        }
    }


    void Move()
    {
        if(LeftMove)
        {
            moveVelocity = new Vector3(-0.10f,0,0);
            transform.position += moveVelocity * speed * Time.deltaTime;
            render.flipX = true;

            //Item방향
            item.star.flipX = true;
            item.water.flipX = true;
            item.poison.flipX = true;
            item.crystal.flipX = true;
            item.ghost.flipY = false;
            item.angel.flipX = true;
            item.bear.flipX = true;
            item.devil.flipX = true;

            anim.SetTrigger("ToRunFromIdle");


        }
        else if(RightMove)
        {
            moveVelocity = new Vector3(+0.10f,0,0);
            transform.position += moveVelocity * speed * Time.deltaTime;
            render.flipX = false;

            //Item방향
            item.star.flipX = false;
            item.water.flipX = false;
            item.poison.flipX = false;
            item.crystal.flipX = false;
            item.ghost.flipY = true;
            item.angel.flipX = false;
            item.bear.flipX = false;
            item.devil.flipX = false;

            anim.SetTrigger("ToRunFromIdle");
        }

        else if(isIdle)
        {
            anim.SetTrigger("ToIdleFromRun");
        }
    }

    void Jump()
    {
        rb.AddForce(Vector2.up * jump * rb.mass, ForceMode2D.Impulse);
        anim.SetTrigger("ToJumpFromIdle");
    }
    //GameManager 클래스에서 사칙연산 함수 시작하는 부분
    void Choice()
    {
        if(Add)
        {
            if(isGrass)
            {
                print("Add or Grass");
                gameManager.Pluss();
                //오브젝트 작아지기 위한 변수
            }

            else if(isSand)
            {
                print("Minuss or Send");
                gameManager.Minuss();
            }

            else if(isStone)
            {
                print("Multiple or Stone");
                gameManager.Multiple();
            }

            else if(isMoss)
            {
                print("Divide or Diamond");
                gameManager.Divide();
            }

            else if(isDiamond)
            {
                print("Add_Mulity");
                gameManager.ThreeNumber_Add_Mulity();
            }
        }

    }
    //오브젝트 작아지게 하는 bool 변수 꺼주기 위함
    void ForInvoke()
    {
        get_coin = false;
    }


    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.layer == LayerMask.NameToLayer("ground"))
        {
            canJump = true;
            anim.SetTrigger("ToIdleFromJump");
        }

        
    }
        
    void OnCollisionStay2D(Collision2D other)
    {
        Vector3 newPos = other.gameObject.transform.position;
        Quaternion newRot = other.gameObject.transform.rotation;

        //태그별로 복사 해야함
        if(other.gameObject.CompareTag("grass"))
        {
            isGrass = true;

            //코인등장하게함
            if(get_coin)
            {
                Destroy(other.gameObject);
                Invoke("ForInvoke", 0.1f);

                for(int i = 0; i<1; i++ )
                {
                    GameObject newOBJ = Instantiate(Coins[0], newPos, newRot);
                }
            }
                
        } // 여기까지 복사 필요.
        else if(other.gameObject.CompareTag("sand"))
        {
            isSand = true;

            if(get_coin)
            {
                Destroy(other.gameObject);
                Invoke("ForInvoke", 0.1f);

                for(int i = 0; i<1; i++ )
                {
                    GameObject newOBJ = Instantiate(Coins[0], newPos, newRot);
                }
            }
        }

        else if(other.gameObject.CompareTag("stone"))
        {
            isStone = true;

            if(get_coin)
            {
                Destroy(other.gameObject);
                Invoke("ForInvoke", 0.1f);

                for(int i = 0; i<1; i++ )
                {
                    GameObject newOBJ = Instantiate(Coins[1], newPos, newRot);
                }
            }
        }

        else if(other.gameObject.CompareTag("moss"))
        {
            isMoss = true;

            if(get_coin)
            {
                Destroy(other.gameObject);
                Invoke("ForInvoke", 0.1f);

                for(int i = 0; i<1; i++ )
                {
                    GameObject newOBJ = Instantiate(Coins[1], newPos, newRot);
                }
            }
        }

        else if(other.gameObject.CompareTag("diamond"))
        {
            isDiamond = true;

            if(get_coin)
            {
                Destroy(other.gameObject);
                Invoke("ForInvoke", 0.1f);

                for(int i = 0; i<1; i++ )
                {
                    GameObject newOBJ = Instantiate(Coins[1], newPos, newRot);
                }
            }
        }
    }

    void OnTriggerEnter2D(Collider2D others)
    {
        if(others.gameObject.CompareTag("Coin_1"))
        {
            Destroy(others.gameObject);
            coin = coin + 1;
            print(coin);

        }
        if(others.gameObject.CompareTag("Coin_10"))
        {
            Destroy(others.gameObject);
            coin = coin + 10;
            print(coin);
        }

        else if(others.CompareTag("Last"))
        {
            isFixAirplan = true;

            print("HELLOSS");
        }

    }
}
    
    
        


    

