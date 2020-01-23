using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Limit player from going offscreen in left direction
        if (transform.position.x < -xRange) 
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        // Limit player from going offscreen in right direction
        if (transform.position.x > xRange) {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Get horizontal input (either W,S or <-.->) from the keyboard
        horizontalInput = Input.GetAxis("Horizontal");
        // Making the player move by multipying the necessary things
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
