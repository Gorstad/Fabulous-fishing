using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text scoreText;  
    public static int score;
    public delegate void CallButton();
    public static event CallButton ManagerButton;
 
    
    void Awake() => ManagerScene.StopGame += ReloadScore;

    void Start() 
    {   
     scoreText = GetComponent<Text>();
     scoreText.text = score.ToString();
    }
    
    public void ScoreAdd(int fishScore)
    {
     score += fishScore;
     scoreText.text =  score.ToString();
     if(score>=1)
     {
        ManagerButton?.Invoke();
     }
    } 
    public void ReloadScore()
    {
        score = 0;
        ManagerScene.StopGame -= ReloadScore;
        
    }
    
}
