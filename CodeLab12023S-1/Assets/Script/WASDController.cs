using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WASDController : MonoBehaviour
{
    private Rigidbody rb;
    public float forceAmount = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("W Pressed");
            rb.AddForce(0,0,forceAmount);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-forceAmount,0,0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0,0,-forceAmount);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(forceAmount,0,0);
        }
    }
}
