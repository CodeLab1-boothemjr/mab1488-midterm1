using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public float speed = 2.0f; // var for speed
    public float maxSpeed = 3.5f; // var for maxspeed, < player maxspeed
    private Rigidbody rb; // var for rigidbody
    private GameObject target; // var for target, ie. player
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // assign rb to this rigidbody
        target = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // frame-based step for speed
        float step =  speed * Time.deltaTime;

        // only add forces if under maxSpeed
        if (rb.velocity.magnitude < maxSpeed)
        {
            //todo swap to add force AI controls
            //transform.LookAt(target.transform.position);
            //rb.AddForce(Vector3.forward * speed);
            
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
        }
    }
}
