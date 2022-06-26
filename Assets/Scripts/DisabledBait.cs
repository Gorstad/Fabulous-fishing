using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisabledBait : MonoBehaviour
{
    [SerializeField] int DisabledTime = 10;

    
    void FixedUpdate()
    {
     Invoke("DisabledOverTime",DisabledTime);
    }

    public void DisabledOverTime()
    {
      gameObject.SetActive(false);
    }
  
}
