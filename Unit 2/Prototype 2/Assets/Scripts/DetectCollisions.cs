using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject); // When there is a collision between this item and other times that has on trigger enter enabled it will destory this object.
        Destroy(other.gameObject); // When there is a collision between this item and other times that has on trigger enter enabled it will destory the other object.
    }
}
