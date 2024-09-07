using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -35f;
    private float bottomLimit = -1f;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than the left limit
        if (transform.position.x < leftLimit)
        {
            //Debug.Log("GONE BEYOND LEFT LIMIT");
            Destroy(gameObject);
            
        } 
            // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            //Debug.Log("GONE BEYOND BOTTOM LIMIT");
            Debug.Log("Game Over!");
            Destroy(gameObject);

            
        }

    }
}
