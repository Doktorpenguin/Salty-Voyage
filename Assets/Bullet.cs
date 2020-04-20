using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject player;
    public GameObject particles;
    public float speed;
    void Start()
    {
        speed = 2;
        player = GameObject.FindGameObjectWithTag("Player");
        this.gameObject.GetComponent<Rigidbody2D>().velocity = (player.transform.position - this.transform.position).normalized * speed;

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
