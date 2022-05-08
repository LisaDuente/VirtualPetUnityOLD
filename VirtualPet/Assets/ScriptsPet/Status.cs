using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour
{

    private int counterHungry;
    private int counterClean;

    private int counterHappy;

    public HungerBarScript hungerBar;
    public CleanBarScript cleanBar;
    public HappyBarScript happyBar;

    private int accumulatorHungry = 1000;
    private int accumulatorClean = 3000;
    private int accumulatorHappy = 2000;
    private int hungry = 10;
    private int clean = 3;
    private int happy = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
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

    public void feed(){
        if( hungry <10){
            hungry++;
            hungerBar.setHunger(hungry);
        }
    }

    public void cleanUp(){
        if(clean <3){
            clean++;
            cleanBar.setClean(clean);
        }
    }

    public void play(){
        if(happy < 10){
            happy++;
            happyBar.setHappy(happy);
        }
    }

}
