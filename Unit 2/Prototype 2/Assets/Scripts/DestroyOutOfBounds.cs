﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.z > topBound) // When projectile flies off the top boundry it will destroy itself.
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound) // When enemies flies off the lower boundry it will destroy itself.
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }
}
