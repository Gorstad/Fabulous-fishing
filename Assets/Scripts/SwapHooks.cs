using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapHooks : MonoBehaviour
{
    public GameObject SingleH,DoubleH;
    EnableBaitButton EnabledBait;
    EnableBaitButton DisabledBait;
    private int Baitbuttint;
    Score Baitscore;

    void Start()
    {
        
    }

    public void SwitchHook()
     {
        DoubleH.SetActive(!DoubleH.activeSelf);
        SingleH.SetActive(!SingleH.activeSelf);
     }
    
    public void SwitchBaitButt()
    {
       if(SingleH.activeSelf)
       {
        EnabledBait = GameObject.Find("Player").GetComponent<EnableBaitButton>();
        EnabledBait.BlockBait = false;
        if(GameObject.Find("Score") != null)
         {
          Baitscore = GameObject.Find("Score").GetComponent<Score>();
          Baitbuttint = Score.score;
         }
         if(Baitbuttint>=1)
         {
          EnabledBait.EnabledButton();
         }
       }
       if(DoubleH.activeSelf)
       {
        DisabledBait = GameObject.Find("Player").GetComponent<EnableBaitButton>();
        DisabledBait.DisBait();
        DisabledBait.BlockBait = true;
       }
    }
}
