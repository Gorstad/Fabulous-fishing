using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishMovment : MonoBehaviour
{
    public float Speed = 1f;
 
    private Transform _hook;
    private Vector3 _hookOffset;
    private bool _isCatched;
 
    private Vector2 _moveTo;
    
 
    void Update()
    {
        if (_isCatched)
        {
            followTheHook();
        }
        else
        {
            justSwimming();
        }
    }
 
    public void Catched(Transform hook)
    {
        _isCatched = true;
        _hook = hook;
        _hookOffset = transform.position - _hook.transform.position;
    }
 
    private void followTheHook()
    {
        transform.position = _hook.position + _hookOffset;
    }
 
    private void justSwimming()
    {
        if ((int)Time.time % 5 == 0)
            _moveTo = Random.insideUnitCircle * 5;
 
        transform.position = Vector3.MoveTowards(transform.position, _moveTo, Time.deltaTime * Speed);
      
    }
 
}
