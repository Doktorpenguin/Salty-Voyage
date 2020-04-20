using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Crew_Manager : MonoBehaviour
{
    public bool job_Repair;
    public bool job_Boarder;
    public Enemy_Ship enemy_S;
    public GameObject crew;
    public float speed;
    public float shootSpeed;
    public int reloadSpeed;
    public Animator anim;
    public bool reloading;
    public GameObject cannon;
    public Player_Controller pc;

    void Start()
    {
        anim = GetComponent<Animator>();
        pc = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Controller>();

        shootSpeed = 2f;
        crew = this.gameObject;
        enemy_S = GameObject.FindGameObjectWithTag("Enemy Ship").GetComponent<Enemy_Ship>();
        job_Repair = true;
        speed = 5;

        //GameObject.FindGameObjectsWithTag("Enemy Crew")
    }

    
    void Update()
    {
        
        //if (Input.GetKey(KeyCode.Q))
        //{
        //    crew.GetComponent<Animator>().SetBool("Job_Repair", false);

        //}

        //if (Input.GetKey(KeyCode.H))
        //{

        //    anim.SetBool("cannonLoaded", true);

        //}

        //if (reloading == true)
        //{
        //    StartCoroutine(reloader());
        //}

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {

            pc.hurt(1);

        }
        
        if (collision.gameObject.tag == "Crew")
        {

            //Damage Crew member

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Enemy Damage")
        {



        }

    }

    public void reload ()
    {

        StartCoroutine(anim.GetBehaviour<Guard_Reload>().reloading());

    }

}
