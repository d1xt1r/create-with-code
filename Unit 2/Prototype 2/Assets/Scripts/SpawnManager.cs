using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs; // Creating an array of prefabs
    private float spawnRangeX = 20; // Range at which the enemies will spawn at
    private float spawnPosZ = 20;  // Position at which the enemies will spawn at

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)) // When S is pressed ->
        {
            int animalIndex = Random.Range(0, animalPrefabs.Length); // animalIndex is variable to store random index from 0 to 3;
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ); // spawnPos is Vector3 variable which stores the random range and the position of the enemies
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation); // -> instanitiate random enemy from the array 
        }
    }
}
