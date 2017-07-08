using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour {

    Animator animator;

    private void Start()
    {
        animator = this.GetComponentInChildren<Animator>();
    }

    public void EndAnimation()
    {
        animator.SetInteger("isLose", 0);
        animator.SetInteger("isWin", 0);
    }
}
