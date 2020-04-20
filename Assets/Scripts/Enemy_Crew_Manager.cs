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
    void Start()
    {
        shootSpeed = 2f;
        crew = this.gameObject;
        enemy_S = GameObject.FindGameObjectWithTag("Enemy Ship").GetComponent<Enemy_Ship>();
        job_Repair = true;
        speed = 5;

    }

    
    void Update()
    {
        
        if (Input.GetKey(KeyCode.Q))
        {
            crew.GetComponent<Animator>().SetBool("Job_Repair", false);

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Enemy Damage")
        {



        }

    }

    IEnumerator firerate()
    {

        yield return new WaitForSeconds(shootSpeed);
        

        yield break;

    }

}
