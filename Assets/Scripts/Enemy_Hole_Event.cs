using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy_Hole_Event : MonoBehaviour
{
    public GameObject enemy_Ship;
    public Enemy_Ship ensh;
    void Start()
    {
        enemy_Ship = GameObject.FindGameObjectWithTag("Enemy Ship");
        enemy_Ship.GetComponent<Enemy_Ship>().shipHealth -= 5;

        ensh = enemy_Ship.GetComponent<Enemy_Ship>();

    }

    
    void Update()
    {
        


    }

    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {

            if (ensh.Wood>= 5)
            {
                ensh.Wood -= 5;
                ensh.shipHealth += 10;
                Destroy(this.gameObject);
            }

        }

    }

}
