using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScore : MonoBehaviour
{
  void Start() => ManagerScene.StopGame += DestroySc;
  public void DestroySc()
  { if (GameObject.Find("ScoreBG") != null)
     {
       ManagerScene.StopGame -= DestroySc;
       Destroy(gameObject);
     }   
  }
}
