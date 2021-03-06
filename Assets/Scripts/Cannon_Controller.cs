﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon_Controller : MonoBehaviour
{
    public GameObject focusedCannon;
    public Cannon_Stats cannonStats;
    public Player_Controller pc;
    public GameObject[] playerCannons;
    public int cannonIndex;
    public GameObject Leak;
    public GameObject cannonBall;
    public Transform tipTransform;
    public GameObject dest_marker;
    public int firingSpeed;
    void Start()
    {
        firingSpeed = 3;

        cannonIndex = 0;
        focusedCannon = playerCannons[cannonIndex];
        focusedCannon.GetComponent<SpriteRenderer>().sprite = focusedCannon.GetComponent<Cannon_Stats>().activeSprite;

    }

    
    public void Update()
    {

        if (focusedCannon != null)
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

            Vector2 direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);

            focusedCannon.transform.up = direction;

            Debug.DrawRay(focusedCannon.transform.position, direction);

        }

        if (Input.GetMouseButtonDown(0) && focusedCannon != null)
        {
            //Select free cannon is no cannon is selected
            if (pc.Ammo >= 1)
            {
                Shoot();
            }


        }

        if (Input.GetMouseButtonDown(1))
        {

            

        }

        //if (cannonIndex > playerCannons.Length)
        //{
        //    cannonIndex = 0;
        //    if (playerCannons[0].GetComponent<Cannon_Stats>().needsReload == true)
        //    {

        //        focusedCannon = null;

        //    }

        //    else { focusedCannon = playerCannons[cannonIndex]; }
        //    //Switch between all cannons until one is cleared
        //}

    }

    private void Shoot()
    {

        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        GameObject cb = Instantiate(cannonBall, tipTransform.position, focusedCannon.transform.rotation);
        GameObject mk = Instantiate(dest_marker, mousePosition, dest_marker.transform.rotation);
        cb.GetComponent<CannonBall_Controller>().destination = mk.transform.position;
        Destroy(mk, 3);

        pc.Ammo -= 1;

        //cannonStats.needsReload = true;
        //focusedCannon.GetComponent<SpriteRenderer>().sprite = focusedCannon.GetComponent<Cannon_Stats>().cannonSprite;
        //focusedCannon = null;

        //cannonIndex += 1;
        //focusedCannon = playerCannons[cannonIndex];

    }

    IEnumerator reloading()
    {
        yield return new WaitForSeconds(firingSpeed);
        focusedCannon = this.gameObject;

        yield break;

    }
}
