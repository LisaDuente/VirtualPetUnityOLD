using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//took away namespace Monobehaviours
public class ChoosingSprite : MonoBehaviour
{
    private SpriteRenderer[] spriteRenderer;

    [SerializeField] private AnimatorOverrideController[] overrideControllersBody;
    [SerializeField] private AnimatorOverrider overriderBody;

    [SerializeField] private AnimatorOverrideController[] overrideControllersFace;
    [SerializeField] private AnimatorOverrider overriderFace;

    [SerializeField] private AnimatorOverrideController[] overrideControllersHead;
    [SerializeField] private AnimatorOverrider overriderHead;

    public int bodyArrayPosition;
    public int headArrayPosition;
    public int faceArrayPosition;

 
    private void Awake() {
        this.spriteRenderer = this.GetComponentsInChildren<SpriteRenderer>();
    }
       // Start is called before the first frame update
    void Start()
    {
        //chooseSprite();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int randomize(){
        var number = Random.Range(0,3);
        return number;
    }

    public void chooseSprite(){
        bodyArrayPosition = randomize();
        headArrayPosition = randomize();
          faceArrayPosition = randomize();
        //spriteRenderer[1].sprite = bodies[2];
        this.overriderBody.setAnimation(this.overrideControllersBody[bodyArrayPosition]);
        this.overriderHead.setAnimation(this.overrideControllersHead[headArrayPosition]);
        this.overriderFace.setAnimation(this.overrideControllersFace[faceArrayPosition]);
        //spriteRenderer[1].sprite = bodies[randomize()];
        //spriteRenderer[2].sprite = faces[randomize()];
        //spriteRenderer[3].sprite = heads[randomize()];
    }

    public void setBodyController(){
        this.overriderBody.setAnimation(this.overrideControllersBody[bodyArrayPosition]);
    }

    public void setHeadController(){
        this.overriderHead.setAnimation(this.overrideControllersHead[headArrayPosition]);
    }

    public void setFaceController(){
       this.overriderFace.setAnimation(this.overrideControllersFace[faceArrayPosition]);
    }


}

