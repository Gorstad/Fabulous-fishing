using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text scoreText;  
    public  int score;
    // public GameObject [] Buckets;
    // private GameObject Instance;
    // [SerializeField] int Step1Score;
    // [SerializeField] int Step2Score;
    // [SerializeField] int Step3Score;
    // [SerializeField] int Step4Score;
    // private bool Step1;
    // private bool Step2;
    // private bool Step3;
    // private bool Step4;
    void Start()
    {
    scoreText = GetComponent<Text>();
    scoreText.text = score.ToString();
    // Instance = Instantiate(Buckets[0]);
    }

    void FixedUpdate()
    {
    //    BucketManager(); 
    }
    public void ScoreAdd(int fishScore)
    {
        score = score + fishScore;
        scoreText.text =  score.ToString();
    }
    // private void BucketManager()
    // // {
    //     if(!Step1 && score>=Step1Score)
    //     {
    //      Destroy(Instance);
    //      Instance = Instantiate(Buckets[1]);
    //      print("Цикл");
    //      Step1 = true;
    //     }
    //     else if(!Step2 && score>=Step2Score)
    //     {
    //         Destroy(Instance);
    //         Instance = Instantiate(Buckets[2]);
    //         Step2 = true;
    //     }
    //     else if(!Step3 && score>=Step3Score)
    //     {
    //         Destroy(Instance);
    //         Instance = Instantiate(Buckets[3]);
    //         Step3 = true;
    //     }
    //     else if(!Step4 && score>=Step4Score)
    //     {
    //         Destroy(Instance);
    //         Instance = Instantiate(Buckets[4]);
    //         Step4 = true;
    //     }
    //    else
    //    {
    //        print("ErorBucket");
    //    }
    // }
}
