using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OW_Navigation_PS : MonoBehaviour
{
    public Rigidbody2D rb;
    private Vector2 movement;
    public int moveSpeed;
    void Start()
    {
        //moveSpeed = 6;
        rb = GetComponent<Rigidbody2D>();

    }

    
    void Update()
    {

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
