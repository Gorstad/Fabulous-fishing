using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchFish : MonoBehaviour
{
    public Rigidbody2D HookAccession;
    public Rigidbody2D rb;
    // [SerializeField] float catchSpeed;
    //  float newFMpos = HookControl.newFpos;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
     void FixedUpdate()
    {
    //     float newFpos = HookAccession.position.y - rb.position.y ;
    //     rb.MovePosition(HookAccession.position-rb.position * catchSpeed * Time.deltaTime);
    }
    public void Catchfish()
    {
     print("Catch!");
    //  {
    //    transform.position = new Vector2(transform.position.x,newFMpos);
    //  }
     
    }
   
}
