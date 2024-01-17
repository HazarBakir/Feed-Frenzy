using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float spawnRangeX = 14;
    public float spawnPosZ = 20;
    public GameObject[] animalPrefabs;
    float startDelay = 2;
    float spawnInterval = 2.5f;
    int animalIndex;
    void Start()
    {
        Invoke(nameof(SpawnRandomAnimalX), startDelay);
        Invoke(nameof(SpawnRandomAnimalZ), startDelay);
        Invoke(nameof(SpawnRandomAnimalZNegative), startDelay);
    }

    void SpawnRandomAnimalX()
    {
        spawnInterval = Random.Range(0.5f, 2.0f);
        animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        Invoke(nameof(SpawnRandomAnimalX), spawnInterval);
    }
    void SpawnRandomAnimalZ()
    {
        spawnInterval = Random.Range(0.5f, 2.0f);
        animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(21, 0, Random.Range(0, 15));
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(animalPrefabs[animalIndex].transform.rotation.x, -90, animalPrefabs[animalIndex].transform.rotation.z));
        Invoke(nameof(SpawnRandomAnimalZ), spawnInterval);
    }
    void SpawnRandomAnimalZNegative()
    {
        spawnInterval = Random.Range(0.5f, 2.0f);
        animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-19, 0, Random.Range(0, 15));
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(animalPrefabs[animalIndex].transform.rotation.x, 90, animalPrefabs[animalIndex].transform.rotation.z));
        Invoke(nameof(SpawnRandomAnimalZNegative), spawnInterval);
    }
}
