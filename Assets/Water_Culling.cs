using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water_Culling : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        this.gameObject.GetComponent<SpriteRenderer>().enabled = false;

    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Cull")
        {

            this.gameObject.GetComponent<SpriteRenderer>().enabled = true;

        }

    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Cull")
        {
            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }

    }
}
