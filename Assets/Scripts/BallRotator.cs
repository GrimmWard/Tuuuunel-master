using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRotator : MonoBehaviour
{
    public Rigidbody _rb;
    public float key_x,z;
    Vector3 currentEulerAngles; 
    public GameObject tunel;
    public bool ispuse;
    public float timer;
    /*void Start()
    {
        StartCoroutine(RotateObject(720, Vector3.right, 1));
    }
    /*public void Update()
    {
        key_x = Input.GetAxis("Horizontal");
        Time.timeScale = timer;
        if (ispuse == true)
        {
            timer = 0;
        }
        else if (ispuse == false)
        {
            timer = 1f;
        }
    }
    public void FixedUpdate()
    {
        //Vector3 movement = new Vector3(0.0f, 0.0f, (Mathf.PI / 2));
        //transform.Translate(movement);
        //_rb.AddForce(movement);
        _rb.velocity = new Vector3(0.0f, 0.0f, (Mathf.PI/2));
        key_x = Input.GetAxis("Horizontal");
        if (key_x < 0)
        {
            Vector3 direction = _rb.transform.position + transform.position;
            _rb.AddForceAtPosition(direction.normalized, transform.position);
            Debug.Log("error1");
            //z += 1f;
            //currentEulerAngles = new Vector3(0, 0, z);
            //this.transform.eulerAngles = currentEulerAngles;
        }
        if (key_x > 0)
        {
            Vector3 direction = _rb.transform.position - transform.position;
            _rb.AddForceAtPosition(direction.normalized, transform.position);
            //z -= 1f;
            //currentEulerAngles = new Vector3(0, 0, z);
            //this.transform.eulerAngles = currentEulerAngles;
        }
    }*/
       /*IEnumerator RotateObject(float angle, Vector3 axis, float inTime)
    {
        // calculate rotation speed
        float rotationSpeed = angle / inTime;

        while (true)
        {
            // save starting rotation position
            transform.localRotation = 
            Quaternion startRotation = transform.localRotation;

            float deltaAngle = 0;

            // rotate until reaching angle
            while (deltaAngle < angle)
            {
                deltaAngle += rotationSpeed * Time.deltaTime;
                deltaAngle = Mathf.Min(deltaAngle, angle);
                transform.rotation = startRotation * Quaternion.AngleAxis(deltaAngle, axis);
                yield return null;
            }

            // delay here
            //yield return new WaitForSeconds(1);
        }
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacle")
        {
            tunel.GetComponent<MoveTunel>().enabled = false;
            ispuse = true;
        }
    }*/
    void Update()
    {
         transform.localRotation = Quaternion.Euler(0.0, 45.0, 0.0);
    }
}