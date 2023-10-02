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
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomAnimal() 
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        int directionIndex = Random.Range(0, 2);
        if (directionIndex == 0) 
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnMaxZ);
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
            
        } 
        else if (directionIndex == 1)
        {
           Vector3 spawnPos = new Vector3(-spawnRangeX, 0, Random.Range(spawnMinZ, spawnMaxZ));
           Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(new Vector3(0,90,0)));
        }
        else if (directionIndex == 2)
        {
              Vector3 spawnPos = new Vector3(spawnRangeX, 0, Random.Range(spawnMinZ, spawnMaxZ));
            Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(new Vector3(0, 270, 0)));
        }
        

        
        
        
    }
}
