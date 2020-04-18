using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon_Controller : MonoBehaviour
{
    public Cannon cannon;
    public GameObject focusedCannon;
    public Cannon_Stats cannonStats;
    public Resources_Controller rc;
    void Start()
    {
        
        

    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.name);
                if (hit.transform.tag == "Cannon")
                {
                    focusedCannon = null;
                    cannon = hit.transform.GetComponent<Cannon_Stats>().cannon;
                    focusedCannon = hit.transform.gameObject;
                }
            }
        }

        if (focusedCannon != null)
        {

            focusedCannon.transform.LookAt(Input.mousePosition);

        }
    }

    private void CreateLeak ()
    {



    }

    private void Shoot()
    {

        rc.Ammo -= 1;
        cannonStats.needsReload = true;

    }
}
