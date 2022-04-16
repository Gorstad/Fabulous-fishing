using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOverTime : MonoBehaviour
{
    [SerializeField] float DestroyTime = 7f;
    void Start()
    {
      Destroy(gameObject,DestroyTime);
    }
}
