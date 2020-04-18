using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    //This script handles the Character's movements and interactions with the world.
    public float moveSpeed;
    public Rigidbody2D rb;
    public Resources_Controller rc;
    
    Vector2 movement;
    void Start()
    {
        rc = GetComponent<Resources_Controller>();
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
            Debug.Log("Meh");
            if (collision.gameObject.tag == "Damage")
            {
                FixLeak(collision.gameObject);              
            }
        }

    }

    void FixLeak(GameObject Leak)
    {
        if (rc.Wood >= 5)
        {
            rc.Wood -= 5;
            Destroy(Leak);
        }

    }
}
