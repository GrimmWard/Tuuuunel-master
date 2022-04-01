using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewAngleRotation : MonoBehaviour
{
    public Rigidbody rb;   
    private float horizontalInput; 
    private float verticalInput; 
    private float speed = 100.0f; 
    Vector3 currentEulerAngles;

     public float key_x;
    public float z, timer;
    public GameObject cylinder;
    void Start()
    {

    }
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        /*if ()
        currentEulerAngles = new Vector3(0.0f, horizontalInput * speed , 0.0f);
        this.transform.eulerAngles = currentEulerAngles;*/
        key_x = Input.GetAxis("Horizontal");
        if (key_x < 0) 
        {
            z += 1f;
            currentEulerAngles = new Vector3(0, 0, z);
            cylinder.transform.eulerAngles = currentEulerAngles;
        }
        if (key_x > 0)
        {
            z -= 1f;
            currentEulerAngles = new Vector3(0, 0, z);
            cylinder.transform.eulerAngles = currentEulerAngles;
        }
    }
}
