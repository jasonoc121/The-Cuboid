using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeBehavior : MonoBehaviour
{
    public GameObject enemy;
    int CHP;
    public int MHP = 100;
    // Start is called before the first frame update
    void Start()
    {
        CHP = MHP;
        print("Get the enemy tank before it reaches the water");
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown("h"))
         //   takeDamage(12);
    }

    private void OnCollisionEnter(Collision collision)
    {
        enemyMissile objecthitdetected = collision.gameObject.GetComponent<enemyMissile>();
        if(objecthitdetected)
        {
            takeDamage(25);

        }
    }


    internal void takeDamage(int damage)
    {
        CHP -= damage;
        print("Enemy Missile impact! Remaining Durability:" + CHP);

        if (CHP <= 0)
            Destroy(enemy);
   
            

    }

    internal int whatsYourMaxHealth()
    {
        return MHP;

    }
}
