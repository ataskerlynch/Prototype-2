using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnMaxZ = 20;
    private float spawnMinZ = -2;
    private float startDelay = 2;
    private float spawnInterval = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        // Generate animals at edge of screen (top, left,right) at specified interval
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    void SpawnRandomAnimal() 
    {
        // Select random animal
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        // Select random direction that the animal will travel
        int directionIndex = Random.Range(0, 3);

        // Instantiate animal based on direction it will be travelling

        // Appear at top and move down
        if (directionIndex == 0) 
        {
            Vector3 spawnPosTop = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnMaxZ);
            Instantiate(animalPrefabs[animalIndex], spawnPosTop, animalPrefabs[animalIndex].transform.rotation);
        } 
        // Appear on left and move right
        else if (directionIndex == 1)
        {
           Vector3 spawnPosRight = new Vector3(-spawnRangeX, 0, Random.Range(spawnMinZ, spawnMaxZ));
           Instantiate(animalPrefabs[animalIndex], spawnPosRight, Quaternion.Euler(new Vector3(0,90,0)));
        }
        // Appear on right and move left
        else if (directionIndex == 2)
        {
            Vector3 spawnPosLeft = new Vector3(spawnRangeX, 0, Random.Range(spawnMinZ, spawnMaxZ));
            Instantiate(animalPrefabs[animalIndex], spawnPosLeft, Quaternion.Euler(new Vector3(0, 270, 0)));
        }
        

        
        
        
    }
}
