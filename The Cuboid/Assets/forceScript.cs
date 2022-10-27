using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forceScript : MonoBehaviour
{
    Rigidbody ourRigidBody;
    public GameObject destroyObject;
    ParticleSystem particle;

    // Start is called before the first frame update
    void Start()
    {
        particle = GetComponent<ParticleSystem>();
        ourRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {


    }
    private void OnCollisionEnter(Collision collision)
    {
        
            missile objecthitdetected = collision.gameObject.GetComponent<missile>();
            if (objecthitdetected)
            {
                particle.Play();
                Destroy(destroyObject, particle.main.duration);
            }
            else
        {


        }
        //planeBehavior objectHitplanebehavior = collision.gameObject.GetComponent< planeBehavior > ();
        // if (objectHitplanebehavior)

        //    print("found planeBehavior in object hit");
        //    objectHitplanebehavior.takeDamage(20);

        //  int ObjectsMaxHealth = objectHitplanebehavior.whatsYourMaxHealth();
        //  if (ObjectsMaxHealth > 100)
        //      objectHitplanebehavior .takeDamage(400);

        // else

        //  print("didnt find planeBehavior in object hit");

        // print("Ouch!");
    }
}