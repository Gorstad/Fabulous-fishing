using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text scoreText;  
    public int score;
    void Start()
    {
    scoreText = GetComponent<Text>();
    scoreText.text = score.ToString();
    }

    void Update()
    {
        
    }
    public void ScoreAdd(int fishScore)
    {
        score = score + fishScore;
        scoreText.text = score.ToString();
    }
}
