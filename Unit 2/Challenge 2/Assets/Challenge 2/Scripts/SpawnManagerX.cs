using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay;
    //private float spawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        // Question 7 - Make the spawn interval a random value between 3 seconds and 5 seconds
        Invoke("SpawnRandomBall", startDelay);

        //InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Question 6 - Generate a random number  from the index, so you can spawn all types of balls
        int ballIndex = Random.Range(0, ballPrefabs.Length);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

       // Instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[0].transform.rotation);

        // Question 7 - Make the spawn interval a random value between 3 seconds and 5 seconds
        startDelay = Random.Range(1, 4);
        Invoke("SpawnRandomBall", startDelay);
    }

}
