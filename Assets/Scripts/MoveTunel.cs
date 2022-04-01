using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTunel : MonoBehaviour
{
    public float key_x;
    public MoveTunel mt;
    Vector3 currentEulerAngles;
    public float z, timer;
    public GameObject cylinder;
    public void FixedUpdate()
    {
        /*key_x = Input.GetAxis("Horizontal");
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
        }*/
    }
   
}
