using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EShip_Search : MonoBehaviour
{

    public Animator anim;
    void Start()
    {

        anim = GetComponent<Animator>();

    }

    

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Player Ship")
        {

            anim.SetBool("seePlayer", true);

        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player Ship")
        {

            anim.SetBool("seePlayer", false);

        }

    }

    public void Reloading ()
    {

        StartCoroutine(anim.GetBehaviour<ES_Reload_Behavior>().reload());

    }

}
