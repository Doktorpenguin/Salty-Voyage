﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class CannonBall_Controller : MonoBehaviour
{
    public Vector3 destination;
    public float speed;
    public GameObject hole;
    public GameObject fire;
    public Rigidbody2D rb;
    public bool canSink;
    public int fireChance;
    void Start()
    {

        canSink = false;
        rb = GetComponent<Rigidbody2D>();
        Destroy(this.gameObject, 8f);
        //Destroy(this.gameObject, 5f);
        fireChance = Random.Range(0, 4);

    }


    void Update()
    {

        //transform.Translate(this.transform.forward * 50 * speed * Time.fixedDeltaTime);
        rb.velocity = (destination - this.transform.position).normalized * speed;
        Debug.DrawLine(this.transform.position, destination, Color.magenta);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Colliding");
        //if (collision.gameObject.tag == "Enemy" && canSink)
        //{

        //    Instantiate(hole, this.transform.position, hole.transform.rotation);
        //    Destroy(this.gameObject);

        //}

        //else
        //{

        //    Destroy(this.gameObject);

        //}

    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Enemy Ship")
        {
            canSink = true;

        }

        if (other.gameObject.tag == "Marker" && canSink)
        {
            Instantiate(hole, this.transform.position, hole.transform.rotation);
            Destroy(other.gameObject);
            Destroy(this.gameObject);

            if (fireChance == 1)
            {

                Instantiate(fire, new Vector3(this.transform.position.x, this.transform.position.y + 1), fire.transform.rotation);
                Destroy(other.gameObject);
                Destroy(this.gameObject);

            }

            else
            {

                Instantiate(hole, this.transform.position, hole.transform.rotation);
                Destroy(other.gameObject);
                Destroy(this.gameObject);

            }

        }

        else if (other.gameObject.tag == "Marker" && canSink == false)
        {

            Destroy(other.gameObject);
            Destroy(this.gameObject);

        }

        }

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Enemy Ship")
        {
            
            canSink = true;

        }

    }

    //private void OnTriggerExit2D(Collider2D collision)
    //{

    //    if (canSink)
    //    {
    //        canSink = false;
    //    }

    //    else
    //    {

    //    }

    //}

}