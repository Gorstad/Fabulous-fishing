using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedtast : MonoBehaviour
{
    public float maxVelocity = 2000f;
    Rigidbody2D _rigidBody;    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if (_rigidBody.velocity.magnitude >= maxVelocity)
{
   _rigidBody.velocity = _rigidBody.velocity.normalized * maxVelocity;
}
    }
}
