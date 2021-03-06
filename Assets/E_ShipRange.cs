﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_ShipRange : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponentInParent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {

            anim.SetBool("playerInRange", true);

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player Ship")
        {

            anim.SetBool("playerInRange", false);

        }
    }
}
