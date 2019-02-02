using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("I died bro");
            Destroy(gameObject);
        }

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Space Rock")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Space Rock ded");
        }
    }
}
