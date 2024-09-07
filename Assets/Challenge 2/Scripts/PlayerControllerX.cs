using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float spawnCooldown = 0.5f;
    private float timeSinceLastSpawn;

    // Update is called once per frame
    void Update()
    {
        //code to deal with the spaming of the spacebar key
        //increase the timer
        timeSinceLastSpawn += Time.deltaTime;

        //check if the space bar is pressed and cooldown has passed
        if(Input.GetKeyDown(KeyCode.Space) && timeSinceLastSpawn >= spawnCooldown)
        {
            //spawn the dog
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            //reset the timer to 0 to start the cooldown period again
            timeSinceLastSpawn = 0f;
        }




        // On spacebar press, send dog
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        //}
    }
}
