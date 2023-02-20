using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animator;

    public void PlayAnimation(string animationName)
    {
        animator.Play(animationName);
    }
}
