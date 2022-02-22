using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractFish : MonoBehaviour
{
    private bool OnHook = false;
    public bool Eaten = false;
   [SerializeField] int fishScoreAdd = 1;

   Score scoreboard;

   

   void Start()
   {
    scoreboard = FindObjectOfType<Score>(); 
   }
  
   void FixedUpdate()
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

            case "Pike":
            if(gameObject.tag =="FishOnHook")
            {
            Invoke("AteOFHook",0.1f);
            }
            else
            {
              Hunt();
            }
              break;
             
        }
    
    }
   private void Catching()
            { 
              if(transform.position.y > 1.3f && OnHook)
              {
                DestroyFish();
                print("Catch");
                scoreboard.ScoreAdd(fishScoreAdd);
              }
            }
   private void Hunt()
   {
    Invoke("DestroyFish",0.2f);
    print("Hunt");
   }
   private void AteOFHook()
   {
     Invoke("DestroyFish",0.1f);
     GameObject.Find("hoook").SendMessage("HookActivate");
   }
}
    