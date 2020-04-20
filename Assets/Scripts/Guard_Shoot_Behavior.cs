using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guard_Shoot_Behavior : StateMachineBehaviour
{
    public GameObject player;
    public float dist;
    public GameObject bullet;
    public bool canShoot;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        player = GameObject.FindGameObjectWithTag("Player");
        canShoot = true;

        Instantiate(bullet, new Vector3(animator.transform.position.x + 3, animator.transform.position.y, 0), bullet.transform.rotation);
        animator.SetBool("shot", true);

    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        
        //RaycastHit2D hit = Physics2D.Raycast(animator.gameObject.transform.position, player.transform.position);
               

    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {



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
