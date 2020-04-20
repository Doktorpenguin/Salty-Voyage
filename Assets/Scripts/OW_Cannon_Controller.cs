using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OW_Cannon_Controller : MonoBehaviour
{
    public GameObject focusedCannon;
    public Cannon cannonStats;
    public Player_Controller pc;
    public GameObject Leak;
    public GameObject cannonBall;
    public Transform tipTransform;
    public GameObject dest_marker;
    public float firingSpeed;
    void Start()
    {
        firingSpeed = cannonStats.reloadSpeed;

        focusedCannon = this.gameObject;
        focusedCannon.GetComponent<SpriteRenderer>().sprite = cannonStats.activeSprite;

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

    }

    private void Shoot()
    {

        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        GameObject cb = Instantiate(cannonBall, tipTransform.position, focusedCannon.transform.rotation);
        GameObject mk = Instantiate(dest_marker, mousePosition, dest_marker.transform.rotation);
        if (cb != null)
        {
            cb.GetComponent<OW_CannonBall_Controller>().players = true;
        }

        if (mk != null)
        {
            cb.GetComponent<OW_CannonBall_Controller>().destination = mk.transform.position;
            Destroy(mk, 8);
        }

        pc.Ammo -= 1;
        focusedCannon.GetComponent<SpriteRenderer>().sprite = cannonStats.cannonSprite;
        focusedCannon = null;
        StartCoroutine(reloading());

        //cannonStats.needsReload = true;
        //focusedCannon.GetComponent<SpriteRenderer>().sprite = focusedCannon.GetComponent<Cannon_Stats>().cannonSprite;

    }

    IEnumerator reloading()
    {
        yield return new WaitForSeconds(3);
        Debug.Log("Reloading");
        focusedCannon = this.gameObject;

        yield break;

    }
}
