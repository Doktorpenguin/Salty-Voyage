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
    public int reloadSpeed;
    void Start()
    {
        reloadSpeed = 3;

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

    public void Reload (Animator an)
    {
        Debug.Log("Trying to reload");
        StartCoroutine("reloading", an);

    }

    IEnumerator reloading(Animator anim)
    {
        Debug.Log("Reloading...");
        yield return new WaitForSeconds(reloadSpeed);
        anim.SetBool("cannonLoaded", true);
        yield break;
    }
}
