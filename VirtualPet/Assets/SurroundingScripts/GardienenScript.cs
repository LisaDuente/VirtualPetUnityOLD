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

public Image dresser;

public Image plush;

public Image bed;

public Image gardienen;

public GameObject Tapete;
private SpriteRenderer renderBackground;
private SpriteRenderer renderTapete;






    void Start (){
        renderBackground= background.GetComponent<SpriteRenderer>();
        renderTapete = Tapete.GetComponent<SpriteRenderer>();
        
    }

  public void setImage(){
      if(image.sprite != open){
        image.sprite = open;
        renderBackground.color = new Color(1,1,1,1);
        renderTapete.color = new Color(1,1,1,1);
        bed.color = new Color(1,1,1,1);
        dresser.color = new Color(1,1,1,1);
        gardienen.color = new Color(1,1,1,1);
        plush.color = new Color(1,1,1,1);
    
      }else{
        image.sprite = closed;
        renderBackground.color = new Color(0.5f,0.4646226f,0.4646226f,1);
        renderTapete.color = new Color(1,1,1,0.2f);
        bed.color = new Color(0.5f,0.4646226f,0.4646226f,1);
        dresser.color = new Color(0.5f,0.4646226f,0.4646226f,1);
        gardienen.color = new Color(0.5f,0.4646226f,0.4646226f,1);    
        plush.color = new Color(0.5f,0.4646226f,0.4646226f,1); 
         
      }
      
  }
}
