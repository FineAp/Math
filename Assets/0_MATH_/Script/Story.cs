using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Story : MonoBehaviour
{
    
    public List<GameObject> story = new List<GameObject>();
    public List<GameObject> bg = new List<GameObject>();

    private int count = 0;
    private int bgCount = 0;

    public void NextStory()
    {
        story[count].SetActive(false);

        count += 1;
        story[count].SetActive(true);

        print(count);

        if(count == 2 )
        {
            bg[bgCount].SetActive(true);

        }

        else if(count == 4 )
        {
            bgCount += 1;
            bg[bgCount].SetActive(true);
        }

        else if(count == 6)
        {
            bgCount +=1;
            bg[bgCount].SetActive(true);
        }

        else if(count == 7)
        {
            SceneManager.LoadScene("Game");
        }
    }

    public void ToGame()
    {
        SceneManager.LoadScene("Game");
    }
    
}   
