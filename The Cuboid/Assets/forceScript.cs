using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forceScript : MonoBehaviour
{
    Rigidbody ourRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        ourRigidBody = GetComponent<Rigidbody>();
        if (Input.GetKeyDown(KeyCode.B))
            ourRigidBody.AddExplosionForce(1000, transform.position + transform.forward, 1);
    }

    // Update is called once per frame
    void Update()
    {
       // if (Input.GetKeyDown(KeyCode.LeftArrow))
        
         //   ourRigidBody.AddExplosionForce(1000,transform.position + Vector3.down, 2) ;
        
    }
    private void OnCollisionEnter(Collision collision)
    {
       //planeBehavior objectHitplanebehavior = collision.gameObject.GetComponent< planeBehavior > ();
       // if (objectHitplanebehavior)
      //  {
        //    print("found planeBehavior in object hit");
        //    objectHitplanebehavior.takeDamage(20);

          //  int ObjectsMaxHealth = objectHitplanebehavior.whatsYourMaxHealth();
          //  if (ObjectsMaxHealth > 100)
          //      objectHitplanebehavior .takeDamage(400);
        }
       // else
        
          //  print("didnt find planeBehavior in object hit");
        
        // print("Ouch!");
    
}