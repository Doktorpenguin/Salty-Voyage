using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardShootRange : MonoBehaviour
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
            if (Random.Range(0, 3) == 1)
            {

                anim.SetBool("shouldShoot", true);

            }

            else
            {
                StartCoroutine(stall());
            }
            //anim.SetBool("shouldShoot", true);

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Crew")
        {

            anim.SetBool("shouldShoot", false);

        }

    }

    IEnumerator stall ()
    {
        yield return new WaitForSeconds(Random.Range(1, 3));
        anim.SetBool("shouldShoot", true);
        yield break;
    }
}
