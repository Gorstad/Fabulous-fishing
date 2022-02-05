using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractFish : MonoBehaviour
{
    private bool OnHook = false;
   void Update()
   {
    Catching();  
   }
   private void DestroyFish()
   {
    Destroy(gameObject);
   }
   void OnTriggerEnter2D(Collider2D collision )
    {
        switch(collision.gameObject.tag)
        {
            case "Wall":
              DestroyFish();
            break;

            case "Player":
              OnHook = true;    
            break;
             
        }
    }
   private void Catching()
            { 
            //    SendMessage("CollissionEnabled");
              if(transform.position.y > 1.4f & OnHook)
              {
                DestroyFish();
                print("Catch");
              }
            }
}
    