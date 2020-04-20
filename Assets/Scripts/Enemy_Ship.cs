using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Ship : MonoBehaviour
{

    public int Wood;
    public int Thread;
    //public int Crew;
    public int Gold;
    public int Ammo;
    public int maxAmmo;
    public int shipHealth;
    public int waterBucket;

    //public GameObject Crew1;
    //public Repair_Behavior Crew1RP;

    void Start()
    {

        //Crew1RP = Crew1.GetComponent<Repair_Behavior>();

        Wood = 10;
        waterBucket = 2;
        shipHealth = 100;
        maxAmmo = 15;
        Ammo = maxAmmo;
        Gold = 20;

    }

    
    void Update()
    {
        


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "damage")
        {

            //Crew1RP.damage = collision.gameObject;

        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }
}
