using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab; // Drag and drop the prefab of the obstacle
    private Vector3 spawnPos = new Vector3(25, 0, 0); // Position at we want our obstacles to spawn

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation); // Spawn a copy of the prefab at the spawnPos and no rotation (the default on the prefab)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
