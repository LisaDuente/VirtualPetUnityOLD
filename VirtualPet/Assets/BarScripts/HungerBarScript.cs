using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerBarScript : MonoBehaviour
{

    public Slider slider;
 
    public void setHunger(int hunger){
        slider.value = hunger;
    }

}
