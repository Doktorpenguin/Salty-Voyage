using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guard_Stab_Range : MonoBehaviour
{
    public Animator anim;
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
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Crew")
        {

            anim.SetBool("shouldStab", false);

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Crew")
        {

            anim.SetBool("shouldStab", true);

        }

    }
}
