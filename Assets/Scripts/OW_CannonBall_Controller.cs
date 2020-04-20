using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class OW_CannonBall_Controller : MonoBehaviour
{
    public Vector3 destination;
    public float speed;
    public Rigidbody2D rb;
    public bool players;
    public GameObject HitFX;
    public GameObject SinkFX;
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        Destroy(this.gameObject, 5f);

    }


    void Update()
    {

        rb.velocity = (destination - this.transform.position).normalized * speed;
        //rb.AddForce(this.transform.forward * speed * 500);
        //rb.MovePosition(destination * speed * Time.deltaTime);
        Debug.DrawLine(this.transform.position, destination, Color.magenta);

        if (rb.velocity.x <= 1 || rb.velocity.y <= 1)
        {
            Instantiate(SinkFX, this.transform.position, SinkFX.transform.rotation);
            Destroy(this.gameObject);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.tag == "Enemy Ship" && players)
        {

            collision.GetComponent<Enemy_Ship>().shipHealth -= 50;
            Instantiate(HitFX, this.transform.position, HitFX.transform.rotation);
            Destroy(this.gameObject);

        }

        if (collision.gameObject.tag == "Player Ship" && players == false)
        {
            //Damage it
            collision.GetComponent<Player_Controller>().shipHealth -= 5;
            Instantiate(HitFX, this.transform.position, HitFX.transform.rotation);
            Destroy(this.gameObject);

        }

    }

}
