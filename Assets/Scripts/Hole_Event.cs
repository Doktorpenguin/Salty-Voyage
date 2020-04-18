using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hole_Event : MonoBehaviour
{
    public TMP_Text text;
    public Resources_Controller rc;
    void Start()
    {

        rc.shipHealth -= 5;

    }

    // Update is called once per frame
    void Update()
    {
        


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            text.gameObject.SetActive(true);

        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        text.gameObject.SetActive(false);
    }
}
