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
    public GameObject blood;
    public GameObject testCube;

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

    public bool hasGunpowder;

    public float shipX;
    public float shipY;
    public Transform widthCorner1;
    public Transform widthCorner2;
    public Transform heightCorner1;
    public Transform heightCorner2;


    void Start()
    {
        moveSpeed = 3;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        hasGunpowder = false;

        playerHealth = 10;
        maxAmmo = 10;
        Ammo = 5;
        waterBucket = 3;
        Wood = 10;
        shipHealthMax = 100;
        shipHealth = shipHealthMax;

        shipX = Vector3.Distance(widthCorner1.position, widthCorner2.position);
        shipY = Vector3.Distance(heightCorner1.position, heightCorner2.position);

        Debug.Log(shipX + "/" + shipY);

    }

    // Update is called once per frame
    void Update()
    {

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Speed", movement.sqrMagnitude);

        if (shipHealth > shipHealthMax)
        {
            shipHealth = shipHealthMax;
        }

        if (Ammo > maxAmmo)
        {
            Ammo = maxAmmo;
        }

        if (playerHealth <= 0)
        {

            Destroy(this.gameObject);
            //Gameover

        }

        if (shipHealth <= 0)
        {

            Destroy(this.gameObject);

        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            float cordX = Random.Range(widthCorner1.position.x, widthCorner2.position.x);
            float cordY = Random.Range(heightCorner1.position.y, heightCorner2.position.y);

            Vector3 cords = new Vector3 (cordX, cordY, 0);

            //Debug.Log("Cords: " + cords);
            Debug.Log(widthCorner1.position.x + "/" + widthCorner2.position.x + "/" + heightCorner1.position.y + "/" + heightCorner2.position.y);
            Instantiate(testCube, cords, testCube.transform.rotation);

        }

    }

    void FixedUpdate()
    {

        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

    }
    #region Collision Detection
    private void OnCollisionStay2D(Collision2D collision)
    {
        //When the player interacts with an object, one of these things will happen based on what their interacting with.
        if (Input.GetKeyDown(KeyCode.E))
        {
            switch (collision.gameObject.tag)
            {

                case "Damage":

                    FixLeak(collision.gameObject);
                    break;

                case "Fire":

                    FixFire(collision.gameObject);
                    break;

                case "Cannon":

                    if (hasGunpowder)
                    {
                        collision.gameObject.GetComponent<Cannon_Stats>().Reload();
                    }
                    else
                    {
                        Debug.Log("You need to grab gun powder!");
                    }

                    break;

                case "Interactable Object":

                    collision.gameObject.GetComponent<Loot_IO>().Take();
                    break;


            }
        }

    }
    #endregion

    public void hurt(int damage)
    {

        playerHealth -= damage;
        Instantiate(blood, this.transform.position, blood.transform.rotation);

    }
    #region Fixes
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
    #endregion
}
