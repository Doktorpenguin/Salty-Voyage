using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OW_ECannon_Controller : MonoBehaviour
{
    public GameObject focusedCannon;
    public Enemy_Ship enemy_S;
    public GameObject cannonBall;
    public Transform tipTransform;
    public GameObject dest_marker;
    void Start()
    {

        //enemy_S = GameObject.FindGameObjectWithTag("Enemy Ship").GetComponent<Enemy_Ship>();

    }

    
    public void Update()
    {



    }

    public  void Shoot(Vector3  cords)
    {

        GameObject cb = Instantiate(cannonBall, tipTransform.position, transform.rotation);
        cb.GetComponent<OW_CannonBall_Controller>().players = false;
        cb.GetComponent<OW_CannonBall_Controller>().destination = cords;

        //enemy_S.Ammo -= 1;

    }
}
