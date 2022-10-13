using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubecontrol : MonoBehaviour
{
    private float turningspeed = 180;
    //public Transform cubeTemplate;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (true)
        {

        }
        if (Input.GetKey(KeyCode.UpArrow))
            transform.position += (transform.forward * Time.deltaTime * 25);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.position -= (transform.forward * Time.deltaTime * 25);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.position -= (transform.right * Time.deltaTime * 25);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.position += (transform.right * Time.deltaTime * 25);
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, turningspeed * -Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, turningspeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.W))
            transform.Rotate(Vector3.right, turningspeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            transform.Rotate(Vector3.right, turningspeed * -Time.deltaTime);
        if (Input.GetKey(KeyCode.Space))
            transform.position += (transform.forward * Time.deltaTime * 100);
        if (Input.GetKeyDown(KeyCode.LeftShift))
            transform.Rotate(Vector3.up, -90);
        if (Input.GetKeyDown(KeyCode.RightShift))
            transform.Rotate(Vector3.up, 90);
    

        //if (Input.GetKeyDown(KeyCode.B))
         //    Instantiate(cubeTemplate, transform.position + transform.forward,
        //         Quaternion.identity);
    }
    
  
  
}
