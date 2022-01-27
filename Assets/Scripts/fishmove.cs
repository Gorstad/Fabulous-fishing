using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 17 января начало

public class fishmove : MonoBehaviour
{
    [SerializeField] float fishSpeed = 10f;
    [SerializeField] int fishScore = 1;
    public Rigidbody2D rb;
    public Vector2 movment;
    public GameObject Hook;
    public GameObject fish;
    public HingeJoint2D hinge;
    
    public bool catching= false;
    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movment * fishSpeed * Time.fixedDeltaTime);
    }

    
            void Catching()
            {
            if (CompareTag ("Fish") && !catching) 
              {
               catching = true;
               Hook = GameObject.FindGameObjectWithTag ("Player");
               Hook.AddComponent<HingeJoint2D> ();
               fish = GetComponent<Collider2D>().gameObject;
               hinge = Hook.GetComponent<HingeJoint2D>();
               rb = fish.GetComponent<Rigidbody2D>();
               hinge.connectedBody = rb;  
              //  rb.isKinematic = true;
              fishSpeed = 0f;
               print("catch");
        
              }
            }
        
        void OnTriggerEnter2D(Collider2D collision )
    {
        switch(collision.gameObject.tag)
        {
            case "Wall":
               Destroy(gameObject);
            break;

            case "Player":
              Catching();      
            break;
        
            // default:
            //    print("nope");
            //    break;
        }
    }
        // Wall wall = collision.GetComponent<Wall>();
        // if (wall !=null)
        // {
        //  Destroy(gameObject);
        // }
        
    
    
}

