using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableBaitButton : MonoBehaviour
{
    private int BaitInt;
    Score BaitScore;
    public Button CreateBite;
    public bool BlockBait = false;
  

    void Awake() => Score.ManagerButton+= EnabledButton;
    
    void  Start ()
    {
     CreateBite.interactable = false;
    }
    public void TransferScore()
    {
     if(GameObject.Find("Score") != null)
     {
       BaitScore = GameObject.Find("Score").GetComponent<Score>();
       BaitInt = Score.score;
       print(BaitInt);
     } 
    }
    
    public void EnabledButton()
    {
      if(!BlockBait)
      {
       CreateBite.interactable = true;
      }
      
    }

    public void DisabledBiteButton()
    {
     if(BaitInt<=0)
     {
      CreateBite.interactable = false;
     }
    }
    public void DisBait()
    {
      CreateBite.interactable = false;
    }
    
}
