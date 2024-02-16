using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefabAnimals;
    private float spawnRangeX = 20;
    private float spawnRangeZ = 20;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 2.0f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        int randomAnimal = Random.Range(0, prefabAnimals.Length);
        Vector3 spawnPos = new(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
        //prefabAnimals[randomAnimal].transform.Rotate(spawnPos);

        Instantiate(prefabAnimals[randomAnimal], spawnPos,
                    prefabAnimals[randomAnimal].transform.rotation);
    }
}
