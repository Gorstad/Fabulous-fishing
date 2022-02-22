using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 17 января начало

public class fishmove : MonoBehaviour
{
    [SerializeField] float fishSpeed = 10f;
    
    public Rigidbody2D rb;
    public Vector2 movment;
    private Transform _hook;
    private Vector3 _hookOffset;
    private bool _isCatched;

    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
      if(!_isCatched)
      {
          rb.MovePosition(rb.position + movment * fishSpeed * Time.fixedDeltaTime);
      }
      else
      {
       followTheHook();
      //  rb.MoveRotation(90);
      }
    }
     public void Catched(Transform hook)
    {
        _isCatched = true;
         gameObject.tag ="FishOnHook";
        _hook = hook;
        _hookOffset = transform.position - _hook.transform.position;
        
    }
 
    private void followTheHook()
    {   
        
        transform.position = _hook.position + _hookOffset;
    } 
}

