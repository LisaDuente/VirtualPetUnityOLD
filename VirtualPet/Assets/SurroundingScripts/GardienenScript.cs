using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GardienenScript : MonoBehaviour
{
public Image image;
public Sprite closed;
public Sprite open;
public GameObject background;
private SpriteRenderer render;




    void Start (){
        render= background.GetComponent<SpriteRenderer>();
    }

  public void setImage(){
      if(image.sprite != open){
        image.sprite = open;
        render.color = new Color(1,1,1,1);
    
      }else{
        image.sprite = closed;
        render.color = new Color(1,1,1,0.2f);
      }
      
  }
}
