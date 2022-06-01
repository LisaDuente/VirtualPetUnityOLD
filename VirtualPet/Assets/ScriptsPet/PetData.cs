using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PetData
{
    //save the current state
   public int hungryPoints;
   public int cleanPoints;
   public int happyPoints;
   public string petState;
   public int amountCoins;

   //save current animator overrider
   public int body;
   public int head;
   public int face;

   //current wallpaper in bedroom
   public int wallpaperBed;

   //bed animation
   public bool sleepingAnimationBed;

   //save position
   public float[] position;
   public string background;

   //colors can be stored in a float array with 4 positions rgba

   public PetData(StatusScript status, ChoosingSprite sprites, PetMovement move, DecorButton decor){
        hungryPoints = status.hungry;
        cleanPoints = status.clean;
        happyPoints = status.happy;
        amountCoins = status.money;
        petState = status.petState.ToString();
        body = sprites.bodyArrayPosition;
        head = sprites.headArrayPosition;
        face = sprites.faceArrayPosition;
        //doesnt work yet
        sleepingAnimationBed = sprites.sleepingAnimation;
        position = new float[3];
        position[0] = move.transform.position.x;
        position[1] = move.transform.position.y;
        position[2] = move.transform.position.z;
        //doesnt work yet
        wallpaperBed = decor.currentWallpaper;
        
   }
}
