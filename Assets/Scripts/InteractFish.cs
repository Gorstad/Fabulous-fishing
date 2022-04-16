using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractFish : MonoBehaviour
{
    private bool OnHook = false;
    public bool Eaten = false;
   [SerializeField] int fishScoreAdd = 1;
   Score scoreboard;
   public GameObject fish;
   public GameObject fishbone;
   public bool FishAdd = false;
   [SerializeField] GameObject ToBucket;
   void Start()
   {
    scoreboard = FindObjectOfType<Score>(); 
   }
  
   void FixedUpdate()
   {
     if(transform.position.y > 1.27f && OnHook)
    {
     Catching();
    }
   
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
                print("Catch");
                scoreboard.ScoreAdd(fishScoreAdd);
                FishAdd = true;
                Instantiate(ToBucket);
                DestroyFish(); 
            }
   private void Hunt()
   {
    CreateBone(fish,fishbone);
    Invoke("DestroyFish",0.2f);
    print("Hunt");
   }
   private void AteOFHook()
   {
     Invoke("DestroyFish",0.1f);
     GameObject.Find("hoook").SendMessage("HookActivate");
   }
    public void CreateBone(GameObject fish, GameObject bone)
    {
    var child =  Instantiate(bone,fish.transform.position,Quaternion.identity);
    }
}
    