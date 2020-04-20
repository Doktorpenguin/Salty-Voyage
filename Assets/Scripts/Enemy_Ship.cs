using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Ship : MonoBehaviour
{

    public Animator anim;

    public int Wood;
    //public int Thread;
    //public int Crew;
    public int Gold;
    public int Ammo;
    public int maxAmmo;
    public int shipHealth;
    public int shipHealthMax;
    public int waterBucket;
    public EShipStats s_Stats;
    public GameObject DeathFX;

    //public GameObject Crew1;
    //public Repair_Behavior Crew1RP;

    void Start()
    {

        anim = GetComponent<Animator>();
        //Crew1RP = Crew1.GetComponent<Repair_Behavior>();

        Wood = s_Stats.Wood;
        waterBucket = s_Stats.waterBucket;
        shipHealthMax = s_Stats.shipHealthMax;
        shipHealth = shipHealthMax;
        maxAmmo = s_Stats.maxAmmo;
        Ammo = maxAmmo;
        Gold = s_Stats.Gold;

    }

    
    void Update()
    {
        
        if (shipHealth <= 0)
        {
            Instantiate(DeathFX, this.transform.position, DeathFX.transform.rotation);
            Destroy(this.gameObject);

        }

        if (shipHealth > shipHealthMax)
        {
            shipHealth = shipHealthMax;
        }

        if (Ammo > maxAmmo)
        {
            Ammo = maxAmmo;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        //if (collision.gameObject.tag == "damage")
        //{

            //Crew1RP.damage = collision.gameObject;

        //}

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }

    public void Reloading()
    {

        StartCoroutine(anim.GetBehaviour<ES_Reload_Behavior>().reload());

    }
}
