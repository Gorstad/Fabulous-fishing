using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishMovment : MonoBehaviour
{
    // public float Speed = 1f;
 
    // private Transform _hook;
    // private Vector3 _hookOffset;
    // private bool _isCatched;
 
    // private Vector2 _moveTo;
    
 
    // void Update()
    // {
    //     if (_isCatched)
    //     {
    //         followTheHook();
    //     }
    //     else
    //     {
    //         justSwimming();
    //     }
    // }
 
    // public void Catched(Transform hook)
    // {
    //     _isCatched = true;
    //     _hook = hook;
    //     _hookOffset = transform.position - _hook.transform.position;
    // }
 
    // private void followTheHook()
    // {
    //     transform.position = _hook.position + _hookOffset;
    // }
 
    // private void justSwimming()
    // {
        
    //     if ((int)Time.time % 1 == 0)
    //         _moveTo = Random.insideUnitCircle * 5;
 
    //     transform.position = Vector3.MoveTowards(transform.position, _moveTo, Time.deltaTime * Speed);
      
    // }
 //дистанция от которой он начинает видеть игрока
    public float seeDistance = 10f;
    //дистанция до атаки
    public float attackDistance = 2f;
    //скорость енеми
    public float speed = 6;
    //игрок
    private Transform target;
    
    void Start ()
    {       
        target = GameObject.FindWithTag ("Player").transform;
    }
    
    void Update ()
    {
        if (Vector3.Distance (transform.position, target.transform.position) < seeDistance) {
            if (Vector3.Distance (transform.position, target.transform.position) > attackDistance) {
                    //walk
                    transform.LookAt (target.transform);
                    transform.Translate (new Vector3 (0, 0, speed * Time.deltaTime));
            }
        } else {
            //idle
        }
    }
}   
