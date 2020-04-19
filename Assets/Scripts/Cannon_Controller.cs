using System.Collections;
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
    void Start()
    {
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

        if (Input.GetMouseButtonDown(0))
        {



            if (pc.Ammo >= 1)
            {
                Shoot();
            }


        }

        if (Input.GetMouseButtonDown(1))
        {

            

        }

        if (cannonIndex > playerCannons.Length)
        {
            cannonIndex = 0;
            if (playerCannons[0].GetComponent<Cannon_Stats>().needsReload == true)
            {

                focusedCannon = null;

            }

            else { focusedCannon = playerCannons[cannonIndex]; }
            //Switch between all cannons until one is cleared
        }

    }

    private void CreateLeak ()
    {



    }

    private void Shoot()
    {

        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);

        focusedCannon.transform.up = direction;

        GameObject cb = Instantiate(cannonBall, tipTransform.position, focusedCannon.transform.rotation);
        cb.GetComponent<CannonBall_Controller>().destination = mousePosition;
        Destroy(cb, 12);

        pc.Ammo -= 1;
        cannonStats.needsReload = true;
        cannonIndex += 1;
        focusedCannon = playerCannons[cannonIndex];
        //Instantiate and fire cannonball

    }
}
