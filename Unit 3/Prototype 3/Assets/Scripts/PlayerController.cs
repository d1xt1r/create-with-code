using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce = 10;
    public float gravityModifier = 2;
    public bool isOnGround = true;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>(); // Get the Rigidbody component of the player
        Physics.gravity *= gravityModifier; // Modifying the default gravity so jumps can feel more natural
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround) // You can jump by pressing space when the player is on the ground
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // Applying jumpforce to the player rb so he can jump
            isOnGround = false; // When you are in the air you cannot jump again
        }
    }

    // Reset isOnGround to true, when the player touches the groud, so you can jump again
    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}
