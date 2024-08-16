using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[ ] animalPrefabs;
    public int animalIndex;
    private float spawnRangeX = 15;
    private float spawnRangeZ = 15;
    private float spawnPosZ = 20;
    private float spawnPosX = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);

        /*InvokeRepeating("SpawnUpAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnLeftAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnRightAnimal", startDelay, spawnInterval);*/
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal() {
        //randomize the spawn position of the animal
        int randomSideSpawn = Random.Range(1, 4);
        switch (randomSideSpawn) 
        {
        case 1:
            SpawnUpAnimal();
            break;
        case 2:
            SpawnLeftAnimal();
            break;
        case 3:
            SpawnRightAnimal();
            break;
        }
    }

    void SpawnUpAnimal() {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos , animalPrefabs[animalIndex].transform.rotation);
    }

    void SpawnLeftAnimal() {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-spawnPosX, 0, Random.Range(2, spawnRangeZ));
        Instantiate(animalPrefabs[animalIndex], spawnPos , Quaternion.Euler(new Vector3(0, 90, 0)));
    }

    void SpawnRightAnimal() {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(2, spawnRangeZ));
        Instantiate(animalPrefabs[animalIndex], spawnPos , Quaternion.Euler(new Vector3(0, -90, 0)));
    }
}
