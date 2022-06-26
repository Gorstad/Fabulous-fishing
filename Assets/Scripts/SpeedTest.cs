using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTest : MonoBehaviour
{
    public float maxVelocity;
    Rigidbody2D _rigidBody;
       
    // Start is called before the first frame update
    void Start()
    {
     _rigidBody = this.GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
         _rigidBody = this.GetComponent<Rigidbody2D>();  
        if (_rigidBody.velocity.magnitude >= maxVelocity)
           {
            _rigidBody.velocity = _rigidBody.velocity.normalized * maxVelocity;
           }
          print(maxVelocity);
    }
}
