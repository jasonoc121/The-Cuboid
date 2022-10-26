using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missileammo : MonoBehaviour
{
    Rigidbody missileBody;
    public GameObject destroyObject;
    ParticleSystem particle;
    public Transform missileTemp;
    // Start is called before the first frame update
    void Start()
    {
        missileBody = GetComponent<Rigidbody>();
        //if (Input.GetKeyDown(KeyCode.Space))
          //  missileBody.AddExplosionForce(1000, transform.position + transform.forward, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Transform newProjectile = Instantiate(missileTemp, transform.position + transform.forward,
                   transform.rotation);
            Rigidbody projectileRB = newProjectile.GetComponent<Rigidbody>();
            projectileRB.useGravity = false;
            projectileRB.AddExplosionForce(100, newProjectile.transform.position - newProjectile.transform.forward, 3);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
       // missile objecthitdetected = collision.gameObject.GetComponent<missile>();
       // if (objecthitdetected)
        {
       //     particle.Play();
       //     Destroy(destroyObject, particle.main.duration);

        }
    }
}