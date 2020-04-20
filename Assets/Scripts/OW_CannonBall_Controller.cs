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

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        //if (collision.gameObject.tag == "Enemy Ship")
        //{

        //Damage it
        //Destroy(this.gameObject);

        //}

        if (collision.gameObject.tag == "Player Ship")
        {
            //Damage it
            Destroy(this.gameObject);

        }

    }

}
