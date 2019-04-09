using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Destroyer : MonoBehaviour
{
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Asteroid")
        {
            Debug.Log("Asteroid destroid.");
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player is ded.");
            Destroy(other.gameObject);
        }
        
    }
}