using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Fire_Controller : Fire_Controller
{
    public GameObject enemy_Ship;
    public Enemy_Ship ensh;
    public bool beingFixed;

    void Start()
    {
        beingFixed = false;
        hasSpread = false;
        spreadChance = Random.Range(0, 2);
        spreadDirection = Random.Range(0, 4);
        StartCoroutine("Timer");

        enemy_Ship = GameObject.FindGameObjectWithTag("Enemy Ship");
        ensh = enemy_Ship.GetComponent<Enemy_Ship>();

        enemy_Ship.GetComponent<Enemy_Ship>().shipHealth -= 1;

    }

    
    void Update()
    {
        
        //Raycast to check if sides are free of collisions.

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Enemy")
        {

            
            if (ensh.waterBucket >= 1)
            {
                ensh.waterBucket -= 1;
                ensh.shipHealth += 1;
                Destroy(this.gameObject);
            }

        }

    }
}
