using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guard_Reload : StateMachineBehaviour
{
    public bool reloaded;
    public Enemy_Crew_Manager esm;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
        reloaded = false;
        esm = animator.GetComponent<Enemy_Crew_Manager>();
        esm.reload();
    }

// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        if (reloaded == true)
        {

            animator.SetBool("shot", false);

        }

    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

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

    public IEnumerator reloading()
    {
        Debug.Log("Reloading...");
        yield return new WaitForSeconds(3);
        reloaded = true;
        yield break;

    }
}
