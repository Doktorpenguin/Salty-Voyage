using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Bullet : MonoBehaviour
{
    public GameObject particles;
    public float speed;
    public Rigidbody2D rb;
    public Vector3 destination;
    void Start()
    {
        speed = 10;
        rb = GetComponent<Rigidbody2D>();
        Destroy(this.gameObject, 3);


    }

    private void Update()
    {
        rb.velocity = (destination - this.transform.position).normalized * speed;

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<Enemy_Crew_Manager>().hurt(2);
            Destroy(this.gameObject);

        }

        else if (collision.gameObject.tag == "Player")
        {
            


        }

        else
        {
            Instantiate(particles, this.transform.position, particles.transform.rotation);
            Destroy(this.gameObject);
        }
    }

}
