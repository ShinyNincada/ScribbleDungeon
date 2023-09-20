using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FistAttackBehavior : StateMachineBehaviour
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       GetRandomFist(animator);
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    // override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    // {
    //    if(stateInfo.normalizedTime % 1 < 0.98f) {
    //         GetRandomFist(animator);
    //    }
    // }

    void GetRandomFist(Animator animator){
        int animationIndex = Random.Range(0, 2);
        animator.SetFloat("FistAnimation", animationIndex);
    }
}
