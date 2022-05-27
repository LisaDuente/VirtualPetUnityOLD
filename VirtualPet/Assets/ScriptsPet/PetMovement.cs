using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetMovement : MonoBehaviour
{
 
    public float moveSpeed = 0.01f;
    public float accuracy = 0.1f;

    public StatusScript statusScript;
    public SpriteRenderer spriteRenderer;
    public Rigidbody2D rb;

    private Animator animatorBody;
    private Animator animatorFace;
    private Animator animatorHead; 
    
    private float moveX;
    private float moveY;
    private bool facingRight;

    public Vector3 touchPosition = new Vector3(0,0,0);
    // Update is called once per frame

    private void Awake() {
        this.animatorBody = GetComponentsInChildren<Animator>()[1];
        this.animatorFace = GetComponentsInChildren<Animator>()[2];
        this.animatorHead = GetComponentsInChildren<Animator>()[3];
    }

    void Start(){
       
    }
   
    void Update()
    {
        //See if there was a touch on screen
        if(Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);
            Debug.Log(touch.position);
            //TODO: compute the ratio of the screen to make it usable on every mobiledevice
            if(touch.position.y > 445 && touch.position.y <1300){
                //convert pixel position to screen position
                touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                touchPosition.z = 0;
            }
            
            
        }
    }

//updates 50 times a second
    void FixedUpdate(){
        if(statusScript.petState == StatusScript.PetState.AWAKE){
            move();
        }
           
       
    }

    void OnCollisionStay2D(Collision2D col){
        //stops if he touches the colliders
        touchPosition = transform.position;
    }

    public void move(){
        //difference between my position and touched position
                moveX = touchPosition.x - transform.position.x;
                moveY = touchPosition.y - transform.position.y;

                //compute length of vector to go (like the little difference between current position and next position for the sprite)
                float lengthMove = Mathf.Sqrt(moveX*moveX + moveY*moveY);
                //normalize the moveVector (length is now one) and rescale with movement speed to get a constant movement speed
                if(lengthMove > moveSpeed){
                    moveX = (moveX/lengthMove)*moveSpeed;
                    moveY = (moveY/lengthMove)*moveSpeed;
                }
                

                if(lengthMove > accuracy){

                     //flips the sprite depending on where you have clicked
                    if(moveX>0 && !facingRight){
                            Flip();
                            facingRight= true;
                        }else if(moveX<0 && facingRight){
                            Flip();
                            facingRight= false;
                        }
                    
                    //add to transform to change the current position on screen (by a little bit in direction of goal position)
                    transform.position = transform.position + new Vector3(moveX,moveY,0);
                    this.animatorBody.SetInteger("Walking", 1);
                }else{
                    this.animatorBody.SetInteger("Walking", 0);
                }
    }
        
    void Flip(){
        // Switch the way the player is labelled as facing
        facingRight = !facingRight;

        // Multiply the player's x local scale by -1
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
