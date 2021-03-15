using System;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 3.0f; // var for speed
    public float maxSpeed = 4.0f; // var for maxspeed
    private Rigidbody rb; // var for rigidbody

    private void Start()
    {
        rb = GetComponent<Rigidbody>(); // assign rb to this rigidbody
    }

    private void Awake()
    {
        //transform.position = GameObject.Find("StartPos").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // frame-based step for speed
        float step =  speed * Time.deltaTime;

        // only add forces if under maxSpeed
        if (rb.velocity.magnitude < maxSpeed)
        {
            // new WASD controls
            if (Input.GetKey(KeyCode.W)) //if W is pressed
            {
                rb.AddForce(Vector3.forward * speed);
            }

            if (Input.GetKey(KeyCode.S)) //if S is pressed
            {
                rb.AddForce(Vector3.back * speed);

            }

            if (Input.GetKey(KeyCode.A)) //if A is pressed
            {
                rb.AddForce(Vector3.left * speed);

            }

            if (Input.GetKey(KeyCode.D)) //if D is pressed
            {
                rb.AddForce(Vector3.right * speed);
            }
        }
    }

    // old ontrigger code
    // todo consider removing
    /*private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "EndPos")
        {
            GameManager.AdvanceCurrentLevel();
        }
    }*/
}
