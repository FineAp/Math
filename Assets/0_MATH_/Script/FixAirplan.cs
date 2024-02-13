using UnityEngine;

public class FixAirplan : MonoBehaviour
{
    public Shop shop;
    public Player player;

    public GameObject particle;
    public GameObject airParitcle;
    public GameObject airPlan;
    public GameObject win;

    public float MaxY;
    public float speed;


    void Update()
    {

        if(shop.haveDevil)
        {
            particle.SetActive(true);
        }

        if(player.isFixAirplan)
        {
            Invoke("Move", 4f);
            airParitcle.SetActive(true);
        }
    }

    void Move()
    {
        //Start UpSide  
        if(MaxY >= airPlan.transform.position.y)
        {
            airPlan.transform.Translate(0f, speed * Time.deltaTime, 0f);
            Invoke("Win", 4f);

        }

        else
        {
            airPlan.SetActive(false);
        }
        
    }
    
    void Win()
    {
        win.SetActive(true);
    }



}
