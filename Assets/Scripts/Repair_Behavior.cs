using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repair_Behavior : StateMachineBehaviour
{
    public GameObject damage;
    //public int repairSpeed
    public Enemy_Ship enemy_s;
    public float speed;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
        enemy_s = GameObject.FindGameObjectWithTag("Enemy Ship").GetComponent<Enemy_Ship>();
        animator.gameObject.GetComponent<SpriteRenderer>().color = Color.gray;

    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        if (GameObject.FindGameObjectWithTag("Enemy Damage") && enemy_s.Wood >= 5)
        {

            damage = GameObject.FindGameObjectWithTag("Enemy Damage");

        }

        else if (GameObject.FindGameObjectWithTag("Enemy Fire") && enemy_s.waterBucket >= 1)
        {

            damage = GameObject.FindGameObjectWithTag("Enemy Fire");

        }

        else
        {

        }

        if (damage != null)
        {
            animator.transform.position = Vector2.MoveTowards(animator.transform.position, damage.transform.position, speed * Time.deltaTime);
        }

    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        animator.gameObject.GetComponent<SpriteRenderer>().color = Color.red;

    }

    public void OnCollisionEnter2D (Collision2D collision)
    {

        Debug.Log("AHHH!");
        if (collision.gameObject.tag == "Enemy Damage")
        {

            FixLeak(collision.gameObject);

        }

        else if (collision.gameObject.tag == "Enemy Fire")
        {

            FixFire(collision.gameObject);

        }

        else { }

    }

    public void FixLeak(GameObject Leak)
    {
        if (enemy_s.Wood >= 5)
        {
            enemy_s.Wood -= 5;
            enemy_s.shipHealth += 5;
            Destroy(Leak);
        }
    }

    public void FixFire(GameObject Fire)
    {
        if (enemy_s.waterBucket >= 1)
        {
            enemy_s.waterBucket -= 1;
            enemy_s.shipHealth += 1;
            Destroy(Fire);
        }
    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
