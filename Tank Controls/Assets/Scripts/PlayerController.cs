using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float turnSpeed = 150;
    private Rigidbody2D rb;
    private Transform tf;
    private float angle = 0.0f;

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
        //When the player presses D they turn right
        if (Input.GetKey(KeyCode.D))
        {
            angle -= turnSpeed * Time.deltaTime;
            tf.rotation = Quaternion.Euler(0, 0, angle);
        }

        //When the player presses A they turn right
        if (Input.GetKey(KeyCode.A))
        {
            angle += turnSpeed * Time.deltaTime;
            tf.rotation = Quaternion.Euler(0, 0, angle);
        }
        //Test is this working
    }
}