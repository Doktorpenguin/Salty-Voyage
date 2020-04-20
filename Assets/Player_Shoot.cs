using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shoot : MonoBehaviour
{

    public Transform tipTransform;
    public GameObject bullet;
    public GameObject dest_marker;
    void Start()
    {

        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);

        //this.transform.up = direction;
        Debug.DrawRay(this.transform.position, direction);

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }

    }

    private void Shoot()
    {

        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        GameObject cb = Instantiate(bullet, tipTransform.position, this.transform.rotation);
        GameObject mk = Instantiate(dest_marker, mousePosition, dest_marker.transform.rotation);
        if (mk != null)
        {
            cb.GetComponent<Player_Bullet>().destination = mk.transform.position;
            Destroy(mk, 3);
        }
    }
}
