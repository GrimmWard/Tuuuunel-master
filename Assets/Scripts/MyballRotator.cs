using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyballRotator : MonoBehaviour
{
    //Vector3 worldRotation = transform.eulerAngles;
    float degreesPerSecond = -20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    Vector3 pivotPoint = new Vector3 (-3.5f,0,0);
    void RotateAroundPoint()
    {
        // Rotates around the pivot point and the Y-Axis by 90 degrees
        transform.RotateAround(pivotPoint, Vector3.up, 90);
    }
}
