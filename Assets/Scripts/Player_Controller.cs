using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    //This script handles the Character's movements and interactions with the world.
    private float moveSpeed;
    public Rigidbody2D rb;
    private Animator anim;
    private Vector2 movement;

    public int playerHealth;

    public int Wood;
    public int Thread;
    public int Crew;
    public int Gold;
    public int Ammo;
    public int maxAmmo;
    public int shipHealth;
    public int shipHealthMax;
    public int waterBucket;


    void Start()
    {
        moveSpeed = 3;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        playerHealth = 10;
        maxAmmo = 10;
        Ammo = 5;
        waterBucket = 3;
        Wood = 10;
        shipHealth = 100;
    }

    // Update is called once per frame
    void Update()
    {

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Speed", movement.sqrMagnitude);

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
