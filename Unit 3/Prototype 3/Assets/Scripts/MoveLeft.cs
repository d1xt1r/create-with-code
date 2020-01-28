using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    private PlayerController PlayerControllerScript; // Variable for storing the reference to the actual PlayerController script


    // Start is called before the first frame update
    void Start()
    {
        PlayerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>(); // Set the reference variable to the actual PlayerController script on the Player object.
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerControllerScript.gameOver == false) // If gameOver (from the PlayerController script) condition is false continue move the obstacles in the left direction
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed); // Moves the obsticle in left direction 
        }
        else // if gameOver (from the PlayerController script) condition is true ->
        {
            transform.Translate(Vector3.zero); // -> Stop moving the obsticle in left direction  
        }
    }
}
