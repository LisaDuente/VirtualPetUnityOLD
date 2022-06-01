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
    public int currentWallpaper = 0; 

    private int wallpaperCount = 2;
    private ArrayList wallPapers = new ArrayList();

    
    void Start(){
        wallPapers.Add(tapete1);
        wallPapers.Add(tapete2);
    }
    
    public void changeWall(){
        if(statusScript.money >= 10){
            if(currentWallpaper <wallpaperCount-1){
                currentWallpaper++;
            }else if(currentWallpaper == wallpaperCount-1){
                currentWallpaper=0;
            }
            Tapete.sprite = (Sprite) wallPapers[currentWallpaper];
            statusScript.money = statusScript.money - 10;
            }
        
        coins.changeText(statusScript.money.ToString());
    }
 
}
