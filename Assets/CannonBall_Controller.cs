using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class CannonBall_Controller : MonoBehaviour
{
    public Vector3 destination;
    public float speed;
    public GameObject hole;
    public Rigidbody2D rb;
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    
    void Update()
    {

        //transform.Translate(this.transform.forward * 50 * speed * Time.fixedDeltaTime);
        rb.velocity = (destination - this.transform.position).normalized * speed;
        Debug.DrawLine(this.transform.position, destination, Color.magenta);

        //if (this.transform.position == destination)
        //{
        //    Debug.Log("Made it!");
        //    Destroy(this);

        //}

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Marker")
        {
            Instantiate(hole, this.transform.position, new Quaternion(0, 0, 0, 0));
            Destroy(this);
        }

    }
}
