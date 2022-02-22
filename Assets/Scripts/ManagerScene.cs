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
    void Start()
    {
     
    }
    void FixedUpdate()
    {
    //  RemainingTime = FindObjectOfType<SimpleTimer>()._timeLeft;
     Rt = GameObject.Find("Time").GetComponent<SimpleTimer>();
     RemainingTime = Rt._timeLeft;
    //  CurrentScore = FindObjectOfType<Score>().score;
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
       Instantiate(LScreeen);
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

