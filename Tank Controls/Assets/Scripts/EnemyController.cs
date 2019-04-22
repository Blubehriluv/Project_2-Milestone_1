using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Transform tf;
    public float speed;
     bool inOne, inTwo, inThree, inFour = false;

    // Use this for initialization
    void Start()
    {
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.name == "Point1")
            {
                //tf.position = tf.position + (Vector3.up * speed);
                Debug.Log("inside the thingy");
                inOne = true;
            }

            if (other.name == "Point2")
            {
                //tf.position = tf.position + (Vector3.down * speed);
                Debug.Log("nope");
                inTwo = true;
            }

            if (other.name == "Point3")
            {
                //tf.position = tf.position + (Vector3.right * speed);
                Debug.Log("stop");
                inThree = true;
            }

            if (other.name == "Point4")
            {
                //tf.position = tf.position + (Vector3.left * speed);
                Debug.Log("different");
                inFour = true;
            }
        }

        void Update()
        {
        if (inOne == true)
        {
            tf.position = tf.position + (Vector3.up * speed);
            Debug.Log("MOVE");
        }
        if (inTwo == true)
        {
            tf.position = tf.position + (Vector3.down * speed);
            Debug.Log("MOVE");
        }
        if (inThree == true)
        {
            tf.position = tf.position + (Vector3.right * speed);
            Debug.Log("MOVE");
        }
        if (inFour == true)
        {
            tf.position = tf.position + (Vector3.left * speed);
            Debug.Log("MOVE");
        }
    }
}