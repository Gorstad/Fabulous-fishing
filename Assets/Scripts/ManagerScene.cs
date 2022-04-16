using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScene : MonoBehaviour
{
    private float RemainingTime;
    private int CurrentScore;
    [SerializeField] int ClaimScore;
    SimpleTimer Rt;
    Score Cs;
    public GameObject LScreeen;
    public GameObject WScreeen;
    private bool  LScreen = false;
    void Start()
    {
     
    }
    void FixedUpdate()
    {
    
     Rt = GameObject.Find("Time").GetComponent<SimpleTimer>();
     RemainingTime = Rt._timeLeft;

     Cs = GameObject.Find("Score").GetComponent<Score>();
     CurrentScore = Cs.score;
     
     if(RemainingTime <= 0)
      {
       Lose();
      }
      if(CurrentScore >= ClaimScore)
      {
       Victory();
       UnLockLevel();
      }
     }
    
    public void Lose()
    {
       Invoke("LoadMenu",5f);
       GameObject.Find("hoook").SendMessage("StopPlay");
       print("Lose");
       if(!LScreen)
       {
        Instantiate(LScreeen);
       }
       LScreen = true;
    }   
    private void LoadMenu()
    {
     SceneManager.LoadScene(0);
    }
    private void Victory()
    {
         print("Win");
    }
    public void UnLockLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if(currentLevel >= PlayerPrefs.GetInt("level"))
        {
            PlayerPrefs.SetInt("level", currentLevel + 1);
        }
    }
}

