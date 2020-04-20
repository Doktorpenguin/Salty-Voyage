using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon_Reload_Behavior : StateMachineBehaviour
{
    public GameObject gunpowderKeg;
    public Vector3 cannonPos;
    public GameObject cannon;
    public Enemy_Ship enemy_S;
    public bool hasGunpowder;
    public float dist;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        cannonPos = animator.transform.position;
        cannon = animator.GetComponent<Enemy_Crew_Manager>().cannon;

        enemy_S = GameObject.FindGameObjectWithTag("Enemy Ship").GetComponentInChildren<Enemy_Ship>();
        gunpowderKeg = GameObject.Find("Powder_Keg");        


    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        dist = Vector3.Distance(animator.transform.position, gunpowderKeg.transform.position);
        float distC = Vector3.Distance(animator.transform.position, cannonPos);

        if (enemy_S.Ammo >= 1 && hasGunpowder == false)
        {

            animator.transform.position = Vector2.MoveTowards(animator.transform.position, gunpowderKeg.transform.position, animator.GetComponent<Enemy_Crew_Manager>().speed * Time.deltaTime);

        }

        if (dist <= 1.5 & hasGunpowder == false)
        {

            hasGunpowder = true;

        }

        if (hasGunpowder)
        {
            animator.transform.position = Vector2.MoveTowards(animator.transform.position, cannonPos, animator.GetComponent<Enemy_Crew_Manager>().speed * Time.deltaTime);
        }        
        
        if (distC <= 1.3 && hasGunpowder)
        {
            Debug.Log("delivered");
            hasGunpowder = false;
            cannon.GetComponent<Enemy_Cannon_Controller>().Reload(animator);

        }

        //else 
        //{
        //    animator.transform.position = Vector2.MoveTowards(animator.transform.position, cannonPos, animator.GetComponent<Enemy_Crew_Manager>().speed * Time.deltaTime);
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
