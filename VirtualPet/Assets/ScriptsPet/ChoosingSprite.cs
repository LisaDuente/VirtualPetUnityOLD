using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MonoBehaviours{
public class ChoosingSprite : MonoBehaviour
{
    private SpriteRenderer[] spriteRenderer;

    [SerializeField] private AnimatorOverrideController[] overrideControllersBody;
    [SerializeField] private AnimatorOverrider overriderBody;

    [SerializeField] private AnimatorOverrideController[] overrideControllersFace;
    [SerializeField] private AnimatorOverrider overriderFace;

    [SerializeField] private AnimatorOverrideController[] overrideControllersHead;
    [SerializeField] private AnimatorOverrider overriderHead;

 
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
        var number = Random.Range(0,10);
        return number;
    }

    public void chooseSprite(){
        var randomBody = randomize();
        var randomFace = randomize();
        var randomHead = randomize();
        //spriteRenderer[1].sprite = bodies[2];
        this.overriderBody.setAnimation(this.overrideControllersBody[0]);
        //spriteRenderer[1].sprite = bodies[randomize()];
        //spriteRenderer[2].sprite = faces[randomize()];
        //spriteRenderer[3].sprite = heads[randomize()];
    }
}

}
