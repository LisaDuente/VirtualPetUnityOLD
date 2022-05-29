using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//took away namespace monobehavoiurs

    public class AnimatorOverrider : MonoBehaviour
{
   private Animator _animator;

    private void Awake() {
        _animator = GetComponent<Animator>();
    }

    public void setAnimation(AnimatorOverrideController overrideController){
        _animator.runtimeAnimatorController = overrideController;
    }
}


