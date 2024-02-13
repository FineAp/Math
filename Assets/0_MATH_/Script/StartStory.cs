using UnityEngine;

public class StartStory : MonoBehaviour
{
    public float time;

    void Start()
    {
        this.gameObject.SetActive(false);

        Invoke("Timmer", time);
        
    }

    void Timmer()
    {
        this.gameObject.SetActive(true);
    }

    
}
