using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float speed = 5.0f;
    Rigidbody enemyRigidbody;
   
    // Start is called before the first frame update
    void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().transform.Translate(Vector3.forward * Time.deltaTime * speed);

      
        }
        
}

