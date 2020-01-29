using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    private PlayerController PlayerControllerScript; // Variable for storing the reference to the actual PlayerController script
    private float leftBound = -15;

    // Start is called before the first frame update
    void Start()
    {
        PlayerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>(); // Set the reference variable to the actual PlayerController script on the Player object.
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerControllerScript.gameOver == false) // If gameOver (from the PlayerController script) condition is false continue move the obstacles and the background in the left direction (if true it will stop moving them)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed); // Moves the obsticle and the background in the left direction
        }

        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
