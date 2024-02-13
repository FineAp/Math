using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public List<Transform> spawnPosYellow;
    public List<Transform> spawnPosBlue;
    public List<Transform> spawnPosGreen;

    public GameObject yellowDoor;
    public GameObject BlueDoor;
    public GameObject GreenDoor;

    public int numberToSpawn = 3;

    void Start()
    {
        SpawnRandom_Yellow(numberToSpawn);
        SpawnRandom_Blue(numberToSpawn);
        SpawnRandom_Green(numberToSpawn);
        
    }

    // Update is called once per frame
    public void SpawnRandom_Yellow(int count)
    {
        if(spawnPosYellow.Count == 0)
        {
            return;
        }

        int spawnCount = Mathf.Min(count, spawnPosYellow.Count);
        for(int i = 0; i<spawnCount; i++)
        {
            int randomIndex = Random.Range(0, spawnPosYellow.Count);
            Transform spawnPos_Y = spawnPosYellow[randomIndex];

            Instantiate(yellowDoor, spawnPos_Y.position, spawnPos_Y.rotation);
            
            spawnPosYellow.RemoveAt(randomIndex);
        }
    }

    public void SpawnRandom_Blue(int count)
    {
        if(spawnPosBlue.Count == 0)
        {
            return;
        }

        int spawnCount = Mathf.Min(count, spawnPosBlue.Count);
        for(int i = 0; i<spawnCount; i++)
        {
            int randomIndex = Random.Range(0, spawnPosBlue.Count);
            Transform spawnPos_B = spawnPosBlue[randomIndex];

            Instantiate(BlueDoor, spawnPos_B.position, spawnPos_B.rotation);
            
            spawnPosBlue.RemoveAt(randomIndex);
        }
    }

    public void SpawnRandom_Green(int count)
    {
        if(spawnPosGreen.Count == 0)
        {
            return;
        }

        int spawnCount = Mathf.Min(count, spawnPosGreen.Count);
        for(int i = 0; i<spawnCount; i++)
        {
            int randomIndex = Random.Range(0, spawnPosGreen.Count);
            Transform spawnPos_G = spawnPosGreen[randomIndex];

            Instantiate(GreenDoor, spawnPos_G.position, spawnPos_G.rotation);
            
            spawnPosGreen.RemoveAt(randomIndex);
        }
    }
}
