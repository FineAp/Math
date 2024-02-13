using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ForKeep : MonoBehaviour
{
    public GameObject[] keep_UI;
    public GameObject player;
    public GameObject OBJ;


    void Update()
    {
        DontDestroyOnLoad(keep_UI[0]);
        DontDestroyOnLoad(keep_UI[1]);

        DontDestroyOnLoad(player);
        DontDestroyOnLoad(OBJ);

        Basic();

        
    }

    void Basic()
    {
        if (SceneManager.GetActiveScene().name == "Story")
        {
            Destroy(keep_UI[0]);
            Destroy(keep_UI[1]);
            Destroy(player);
            Destroy(OBJ);
            
        }
    }

    void Clear()
    {
        if (SceneManager.GetActiveScene().name == "Clear")
        {
            Destroy(keep_UI[0]);
            Destroy(keep_UI[1]);
            Destroy(player);
            Destroy(OBJ);
            
        }
    }
    
}
