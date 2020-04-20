using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ES_Chase_Behavior : StateMachineBehaviour
{
    public Vector3 playerPos;
    public float speed;
    public int dist;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        speed = animator.GetComponent<Enemy_Ship>().speed;

    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        //Vector2 direction = new Vector2(playerPos.x - playerPos.x, playerPos.y - animator.transform.position.y);

        //animator.transform.up = direction;

        playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;

        animator.transform.position = Vector2.MoveTowards(animator.transform.position, playerPos, speed * Time.deltaTime);

        //if (dist <= 5)
        //{

        //    animator.SetBool("playerInRange", true);

        //}

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
