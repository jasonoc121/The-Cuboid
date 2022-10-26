using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankControl : MonoBehaviour
{
    private float speed = 10.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    private float turboBoost = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        forwardInput = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.LeftShift))
            transform.Translate(Vector3.forward * Time.deltaTime * speed * turboBoost);

       transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
       transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

    }
}
