using System;
using UnityEngine;
using Random = System.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIndex;
    Random number = new Random();
    public float startDelay = 2f;
    public float spawnInterval = 1.5f;
    public void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    public void Update()
    {
    

    }
    void SpawnRandomAnimal()
    //had to use a different random method, one taught in CWC didn't work.
    {
        Instantiate(animalPrefabs[number.Next(0,animalPrefabs.Length)], new Vector3(
        (float)number.Next(-20, 20),0,25), animalPrefabs[animalIndex].transform.rotation);
    }
}
