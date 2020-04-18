using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    //This script handles the Character's movements and interactions with the world.
    public float moveSpeed;
    public Rigidbody2D rb;

    public int Wood;
    public int Thread;
    public int Crew;
    public int Gold;
    public int Ammo;
    public int maxAmmo;
    public int shipHealth;
    public int waterBucket;

    Vector2 movement;
    void Start()
    {

        maxAmmo = 10;
        waterBucket = 1;
        Wood = 10;
        shipHealth = 100;
    }

    // Update is called once per frame
    void Update()
    {

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        
    }

    void FixedUpdate()
    {

        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (collision.gameObject.tag == "Damage")
            {
                FixLeak(collision.gameObject);     
                //Repair(collision.gameObject, 5, Wood, 5);
            }

            else if (collision.gameObject.tag == "Fire")
            {

                FixFire(collision.gameObject);

            }
        }

    }

    void FixLeak(GameObject Leak)
    {
        if (Wood >= 5)
        {
            Wood -= 5;
            shipHealth += 5;
            Destroy(Leak);
        }
    }

    void FixFire(GameObject Fire)
    {
        if (waterBucket >= 1)
        {
            waterBucket -= 1;
            shipHealth += 1;
            Destroy(Fire);
        }
    }

    void Repair(GameObject damage, int shipDamage, int resource, int cost)
    {
        if (resource >= cost)
        {
            resource = 5;
            shipHealth += shipDamage;
            Destroy(damage);
        }
    }
}
