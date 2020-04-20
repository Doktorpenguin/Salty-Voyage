using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon_Fire_Behavior : StateMachineBehaviour
{
    public GameObject target;
    public Enemy_Cannon_Controller Enemy_C;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        Enemy_C = GameObject.FindGameObjectWithTag("Enemy Cannon").GetComponent<Enemy_Cannon_Controller>();


        float cordX = Random.Range(-9, 14);
        float cordY = Random.Range(28, 21);

        Vector3 cords = new Vector3(cordX, cordY, 0);

        Enemy_C.Shoot(cords);
        animator.SetBool("cannonLoaded", false);

    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        

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
