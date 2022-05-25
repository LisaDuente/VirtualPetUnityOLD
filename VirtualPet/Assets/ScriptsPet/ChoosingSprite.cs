using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosingSprite : MonoBehaviour
{
    private SpriteRenderer[] spriteRenderer;

    public Sprite[] bodies = new Sprite[8];
    public Sprite[] faces = new Sprite[8];
    public Sprite[] heads = new Sprite[8];
    // Start is called before the first frame update
    void Start()
    {
        this.spriteRenderer = this.GetComponentsInChildren<SpriteRenderer>();
        chooseSprite();
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
        spriteRenderer[1].sprite = bodies[randomize()];
        spriteRenderer[2].sprite = faces[randomize()];
        spriteRenderer[3].sprite = heads[randomize()];
    }
}
