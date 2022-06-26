using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaitSprites : MonoBehaviour
{
    private int RandSprites;
    public Sprite[] SpriteBait;

    
    void Start()
    {
     ChangeSprite();
    }

    public void ChangeSprite()
    {
     RandSprites = Random.Range(0, SpriteBait.Length);
     GetComponent<SpriteRenderer>().sprite = SpriteBait[RandSprites];
    }

}

   
