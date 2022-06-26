using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOverTime : MonoBehaviour
{
    [SerializeField] float DestroyTime = 7f;
    public bool Destruction = true;
    void Start()
    {
      if(Destruction)
      {
       Destroy(gameObject,DestroyTime);
      }
      
    }
}
