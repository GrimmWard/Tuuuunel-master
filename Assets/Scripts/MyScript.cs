using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    public Rigidbody rb;   
    private float horizontalInput; 
    private float verticalInput; 
    private float speed = 10.0f; 

    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        //verticalInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(horizontalInput, 0.0f, 0.0f) * speed);
    }
}
