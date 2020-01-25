using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    // Question 8 - Only allow the player to spawn a new dog after a certain amount of time has passed
    private float fireInterval = 0.7f; // Variable for the allowed fire interval
    private float nextFire = 0.0f;     // Variable for storing the calculated next fire 

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire) // If space is pressed and the time since the scene is started is greater than the calulated nex fire
        {
            nextFire = Time.time + fireInterval; // You are allowed to fire when scene is started and fireInterval is passed.
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
