using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HappyBarScript : MonoBehaviour
{
  public Slider slider;

  public void setHappy(int happy){
      slider.value = happy;
  }
}
