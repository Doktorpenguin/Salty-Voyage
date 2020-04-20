using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject player;
    public Vector3 playerPos;
    public GameObject particles;
    public float speed;
    public Rigidbody2D rb;
    void Start()
    {
        speed = 10;
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
        Destroy(this.gameObject, 3);

        playerPos = player.transform.position;

    }

    private void Update()
    {
        rb.velocity = (playerPos - this.transform.position).normalized * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Player_Controller>().hurt(1);
            Destroy(this.gameObject);

        }

        else
        {
            Instantiate(particles, this.transform.position, particles.transform.rotation);
            Destroy(this.gameObject);
        }
    }

}
