using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusScript : MonoBehaviour
{

    private int counterHungry;
    private int counterClean;
    private int counterHappy;

    public enum PetState{
        AWAKE,
        SLEEPING
    }

    public HungerBarScript hungerBar;
    public CleanBarScript cleanBar;
    public HappyBarScript happyBar;
    public CoinScript coins;
    public SpriteRenderer render;
    private SpriteRenderer[] allRender;

    public Animator animator;

    private int accumulatorHungry = 1000;
    private int accumulatorClean = 3000;
    private int accumulatorHappy = 2000;
    public int hungry;
    public int clean;
    public int happy;
    public PetState petState;
    public int money;

    // Start is called before the first frame update
    void Start()
    {
        //petState = PetState.AWAKE;
        allRender = GetComponentsInChildren<SpriteRenderer>();

    }

    void FixedUpdate()
    {
        if(petState == PetState.AWAKE){
            updateStats();
        }
        
       
    }

    public void feed(){
        if( hungry <10 && petState == PetState.AWAKE){
            hungry++;
            hungerBar.setHunger(hungry);

            money++;
            coins.changeText(money.ToString());
        }
        
    }

    public void cleanUp(){
        if(clean <3 && petState == PetState.AWAKE){
            clean++;
            cleanBar.setClean(clean);
        }
    }

    public void play(){
        if(happy < 10 && petState == PetState.AWAKE){
            happy++;
            happyBar.setHappy(happy);
        }
    }

    public void sleep(){
        if(petState == PetState.AWAKE){
            petState = PetState.SLEEPING;
            foreach (SpriteRenderer render in allRender)
            {
                render.color = new Color(1,1,1,0);
            }
            
        }else{
            petState = PetState.AWAKE;
            foreach (SpriteRenderer render in allRender)
            {
                render.color = new Color(1,1,1,1);
            }
        }
        
    }

//maybe use later to touch pet and raise happiness
/*    public void touchedByU(){
        Debug.Log(animator.GetBool("isTouched"));
        if(!animator.GetBool("isTouched")){
            animator.SetBool("isTouched",true);
        }
        play();
    }
    */

    public void updateStats(){
        counterHungry++;
        counterClean++;
        counterHappy++;

        if(counterHungry >= accumulatorHungry){
            counterHungry = 0;
            hungry --;
            hungerBar.setHunger(hungry);
        }

        if(counterClean >= accumulatorClean){
            counterClean = 0;
            clean--;
            cleanBar.setClean(clean);
        }

        if(counterHappy >= accumulatorHappy){
            counterHappy = 0;
            happy--;
            happyBar.setHappy(happy);
        }
    }
}

