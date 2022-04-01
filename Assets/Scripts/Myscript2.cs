using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myscript2 : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector3(0.0f, 0.0f, (Mathf.PI / 2));
    }
}
