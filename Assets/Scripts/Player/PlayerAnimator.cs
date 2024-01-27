using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    public Animator animator;
    
    public void SetRun(bool run)
    {
        animator.SetBool("IsRunning", run);
    }
    public void SetJump(bool jump)
    {
        animator.SetBool("IsJump", jump);
    }

    public void SetDie(bool die)
    {
        animator.SetBool("IsDie", die);
    }
}
