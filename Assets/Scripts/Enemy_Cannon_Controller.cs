using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Cannon_Controller : MonoBehaviour
{
    public GameObject focusedCannon;
    public Enemy_Ship enemy_S;
    public GameObject Leak;
    public GameObject cannonBall;
    public Transform tipTransform;
    public GameObject dest_marker;
    void Start()
    {
        focusedCannon = this.gameObject;

        enemy_S = GameObject.FindGameObjectWithTag("Enemy Ship").GetComponent<Enemy_Ship>();

    }

    
    public void Update()
    {

        if (focusedCannon != null)
        {

            //Debug.DrawRay(focusedCannon.transform.position, dest_marker.transform.position);

        }

    }

    public  void Shoot(Vector3  cords)
    {

        GameObject cb = Instantiate(cannonBall, tipTransform.position, focusedCannon.transform.rotation);
        GameObject mk = Instantiate(dest_marker, cords, dest_marker.transform.rotation);
        cb.GetComponent<CannonBall_Controller>().destination = mk.transform.position;
        Destroy(mk, 3);

        enemy_S.Ammo -= 1;

    }
}
