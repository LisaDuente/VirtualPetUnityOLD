using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CoinScript : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;

    public void changeText(string textInput){
        textDisplay.text = textInput;
    }
}
