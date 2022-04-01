using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform Ball;
    public Vector3 offset;
    void Start()
    {
        Ball = GameObject.Find("Ball").transform;
    }
    void Update()
    {
        transform.position = Ball.position + offset;
    }
}
