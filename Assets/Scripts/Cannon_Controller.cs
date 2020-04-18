using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon_Controller : MonoBehaviour
{
    public Cannon cannon;
    public GameObject focusedCannon;
    public Cannon_Stats cannonStats;
    public Player_Controller pc;
    public float meh;
    void Start()
    {
        
        

    }

    
    void Update()
    {
        //focusedCannon.transform.position = Input.mousePosition;
        Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        float addAngle = 270;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg + addAngle;

        focusedCannon.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        //if (Input.GetMouseButtonDown(0))
        //{
            
        //    Vector2 rayPos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        //    RaycastHit2D hit = Physics2D.Raycast(rayPos, Vector2.zero, 0f);
            
        //    if (hit.transform.tag == "Cannon")
        //    {
        //        //focusedCannon = null;
        //        cannon = hit.transform.GetComponent<Cannon_Stats>().cannon;
        //        focusedCannon = hit.transform.gameObject;
        //    }

        //}

        if (focusedCannon != null)
        {
            Debug.DrawRay(focusedCannon.transform.position, dir);
            //focusedCannon.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);


        }

        if (Input.GetMouseButtonDown(1))
        {

            focusedCannon = null;

        }

    }

    private void CreateLeak ()
    {



    }

    private void Shoot()
    {

        pc.Ammo -= 1;
        cannonStats.needsReload = true;

    }
}
