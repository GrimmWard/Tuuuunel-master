using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myscript3 : MonoBehaviour
{
    public Vector3 myPos;
    public Transform myPlay;
    public Vector3 offset;
 
    public void Update()
    {
        transform.position = myPlay.position + myPos + offset;
    }
}
