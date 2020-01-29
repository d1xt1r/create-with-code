using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab; // Drag and drop the prefab of the obstacle
    private Vector3 spawnPos = new Vector3(25, 0, 0); // Position at we want our obstacles to spawn
    private float startDelay = 2.0f;
    private float repeatRate = 2.0f;
    private PlayerController PlayerControllerScript; // Variable for storing the reference to the actual PlayerController script

    // Start is called before the first frame update
    void Start()
    {
        PlayerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if(PlayerControllerScript.gameOver == false) // If gameOver (from the PlayerController script) condition is false continue spawning obstacles (if true it will stop spawning them)        
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation); // Spawn a copy of the prefab at the spawnPos and no rotation (the default on the prefab)
        }
    }
}
