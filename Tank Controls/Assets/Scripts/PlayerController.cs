using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 5;
    public float reverseSpeed = 2;
    public float turnSpeed = 200;
    private Rigidbody2D rb;
    private Transform tf;
    private float angle = 0.0f;
    public float force = 10;

    // Use this for initialization
    void Start()
    {
        //Creating variables for the transform components
        rb = GetComponent<Rigidbody2D>();
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // Add force
        //rb.AddForce(transform.up * force);
      

        //Left Movement
        if (Input.GetKey(KeyCode.D))
        {
            angle -= turnSpeed * Time.deltaTime;
            tf.rotation = Quaternion.Euler(0, 0, angle);
        }

        //Right Movement
        if (Input.GetKey(KeyCode.A))
        {
            angle += turnSpeed * Time.deltaTime;
            tf.rotation = Quaternion.Euler(0, 0, angle);
        }

        //Forward Movement
        if (Input.GetKey(KeyCode.W))
        {
            tf.position += (tf.TransformDirection(Vector3.up) * speed * Time.deltaTime);
            rb.AddForce(transform.up * force);
        }

        //Backwards Movement
        /*
        if (Input.GetKey(KeyCode.S))
        {
            tf.position += (tf.TransformDirection(Vector3.down) * reverseSpeed * Time.deltaTime);
        }*/
    }
}