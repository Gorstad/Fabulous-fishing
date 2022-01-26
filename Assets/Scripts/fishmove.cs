using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 17 января начало

public class fishmove : MonoBehaviour
{
    [SerializeField] float fishSpeed = 10f;
    [SerializeField] int fishScore = 1;
    private Rigidbody2D rb;
    public Vector2 movment;
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

    void OnTriggerEnter2D(Collider2D collision)
    {
        switch(collision.gameObject.tag)
        {
            case "Destroy":
               Destroy(gameObject);
            break;
            case "Player":
              print("catch");
              
            break;
            // default:
            //    print("nope");
            //    break;
        }
        // Wall wall = collision.GetComponent<Wall>();
        // if (wall !=null)
        // {
        //  Destroy(gameObject);
        // }
        
    }
}
