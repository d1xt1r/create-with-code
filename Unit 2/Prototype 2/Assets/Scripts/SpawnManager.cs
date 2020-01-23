using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs; // Creating an array of prefabs

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)) // When S is pressed ->
        {
            int animalIndex = Random.Range(0, animalPrefabs.Length); // Index of the array is set to random from 0 to 3 (3 is exclusive);
            // -> instanitiate an random enemy from the array at z position and do not change the rotation
            Instantiate(animalPrefabs[animalIndex], new Vector3(0, 0, 20), animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
