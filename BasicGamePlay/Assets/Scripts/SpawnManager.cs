using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float delay = 2f;
    private float spawnInteval = 1.5f;

    public float spawnRangeX = 20;
    public float spawnPosZ = 20;

    public GameObject animalsFolder;
    public GameObject[] animalPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", delay, spawnInteval);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnRandomAnimal()
    {
        int index = Random.Range(0, animalPrefabs.Length);
        var pos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[index], pos, animalPrefabs[index].transform.rotation, animalsFolder.transform);
    }
}
