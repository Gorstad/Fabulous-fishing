using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterLose : MonoBehaviour
{
 
void Start() => ManagerScene.StopGame += ToDestroy;
    

private void ToDestroy()
 {
  ManagerScene.StopGame -= ToDestroy;
  Destroy(gameObject);
 }
}