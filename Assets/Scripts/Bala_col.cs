using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala_col : MonoBehaviour
{
    public float key_x,z;
    Vector3 currentEulerAngles;
    public Rigidbody rb;

    void FixedUpdate()
    {
        rb.velocity = new Vector3(0.0f, 0.0f, (Mathf.PI / 2));
        key_x = Input.GetAxis("Horizontal");
        if (key_x < 0) 
        {
            z += 3f;
            currentEulerAngles = new Vector3(0, 0, z);
            this.transform.eulerAngles = currentEulerAngles;
        }
        if (key_x > 0)
        {
            z -= 3f;
            currentEulerAngles = new Vector3(0, 0, z);
            this.transform.eulerAngles = currentEulerAngles;
        }
    }
}
