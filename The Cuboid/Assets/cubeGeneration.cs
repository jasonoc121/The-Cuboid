using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeGeneration : MonoBehaviour
{ public Transform cubeTemplate;
    Rigidbody ourRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        ourRigidBody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
           Transform newProjectile =  Instantiate(cubeTemplate, transform.position + transform.forward,
                  transform.rotation);
            Rigidbody projectileRB = newProjectile.GetComponent<Rigidbody>();
            projectileRB.useGravity = false;
            projectileRB.AddExplosionForce(100, newProjectile.transform.position - newProjectile.transform.forward,3);
        }
            
    }
}
