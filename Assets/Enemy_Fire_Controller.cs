using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Fire_Controller : Fire_Controller
{
    public GameObject enemy_Ship;

    void Start()
    {
        hasSpread = false;
        spreadChance = Random.Range(0, 2);
        spreadDirection = Random.Range(0, 4);
        StartCoroutine("Timer");

        enemy_Ship = GameObject.FindGameObjectWithTag("Enemy Ship");

        enemy_Ship.GetComponent<Enemy_Ship>().shipHealth -= 1;

    }

    
    void Update()
    {
        
        //Raycast to check if sides are free of collisions.

    }
}
