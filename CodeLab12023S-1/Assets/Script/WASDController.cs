using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WASDController : MonoBehaviour
{
    private Rigidbody rb;
    private static int forceAmount;
    
    //public float speed = 5;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        forceAmount = BlockCollision.force;
        //get force amount from another script, based on what block player collided with
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0,0,forceAmount);
            //transform.position += Vector3.forward * speed * Time.deltaTime;; 
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-forceAmount,0,0);
            //transform.position += Vector3.left * speed * Time.deltaTime;; 
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0,0,-forceAmount);
            //transform.position += Vector3.back * speed * Time.deltaTime;; 
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(forceAmount,0,0);
            //transform.position += Vector3.right * speed * Time.deltaTime;; 
        }
        
        Debug.Log("force:" + forceAmount);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "double")
        {
            //Debug.Log("double");
            forceAmount *= 2;
        }
        //somehow this doubling is not feeding back into the Update function...
    }
}
