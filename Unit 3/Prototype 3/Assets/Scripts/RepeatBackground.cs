using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos; // Variable for storing the starting position of the Background
    private float repeatWidth;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position; // Starting position of the Background
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPos.x - repeatWidth) // If the current position of the Background is less than the starting with an offset, reset the position
        {
            transform.position = startPos;
        }
    }
}
