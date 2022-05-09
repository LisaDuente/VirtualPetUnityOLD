using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public GameObject pet;

    void Start(){

    }

    public void sleepBed(){
        
        if(animator.GetBool("isSleeping")){
            animator.SetBool("isSleeping",false);      
        }else{
            animator.SetBool("isSleeping",true);
  
        }
    }
}
