using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CleanBarScript : MonoBehaviour
{
   public Slider slider;

   public void setClean(int clean){
       slider.value = clean;
   }
}
