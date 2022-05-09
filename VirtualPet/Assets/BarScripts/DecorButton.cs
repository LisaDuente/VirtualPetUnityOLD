using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecorButton : MonoBehaviour
{

    public SpriteRenderer Tapete;

    public StatusScript statusScript;
    public CoinScript coins;

    public Sprite tapete1;
    public Sprite tapete2;

    private int wallpaperCount = 2;
    private ArrayList wallPapers = new ArrayList();

    private int i = 0;
    
    void Start(){
        wallPapers.Add(tapete1);
        wallPapers.Add(tapete2);
    }
    
    public void changeWall(){
        if(statusScript.money >= 10){
            if(i <wallpaperCount-1){
                i++;
            }else if(i == wallpaperCount-1){
                i=0;
            }
            Tapete.sprite = (Sprite) wallPapers[i];
            statusScript.money = statusScript.money - 10;
            }
        
        coins.changeText(statusScript.money.ToString());
    }
 
}
