using System;
using UnityEngine;
using Random = System.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIndex;
    Random number = new Random();

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(animalPrefabs[number.Next(0,37) % 4], new Vector3((float)number.Next(-20, 
            20),0,25), animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
