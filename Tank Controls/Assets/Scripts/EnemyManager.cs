using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    //public PlayerHealth playerHealth;       // Reference to the player's heatlh.
    public GameObject Enemy;                // The enemy prefab to be spawned.
    public float spawnTime = 7f;            // How long between each spawn.
    //public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
    //public Vector3 spawnPoint;
    private int spawnPointX;
    private int spawnPointY;
    //public bool goDown, goUp, goLeft, goRight = false;


    void Start()
    {
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        InvokeRepeating("Spawn", spawnTime, spawnTime);
        
    }


    void Spawn()
    {
        /* If the player has no health left...
        if (playerHealth.currentHealth <= 0f)
        {
            // ... exit the function.
            return;
        }*/

        // Find a random index between zero and one less than the number of spawn points.
        int whichPoint = Random.Range(0, 3);
        

        if (whichPoint == 0)
        {
            spawnPointX = 0;
            spawnPointY = -12;
            goUp = true;

        }

        if (whichPoint == 1)
        {
            //spawnPoint = new Vector3(0, 12, 0);
            spawnPointX = 0;
            spawnPointY = 12;
            goDown = true;
        }

        if (whichPoint == 2)
        {
            //spawnPoint = new Vector3(-12, 0, 0);
            spawnPointX = -12;
            spawnPointY = 0;
            goLeft = true;
        }

        if (whichPoint == 3)
        {
            //spawnPoint = new Vector3(12, 0, 0);
            spawnPointX = 12;
            spawnPointY = 0;
            goRight = true;
        }
        Vector3 spawnPoint = new Vector3(spawnPointX, spawnPointY, 0);


        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
        Instantiate(Enemy, spawnPoint, Quaternion.identity);
    }
}
