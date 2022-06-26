using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManagerScene : MonoBehaviour 
{
    private float RemainingTime;
    private int CurrentScore;
    [SerializeField] int ClaimScore;
    SimpleTimer Rt;
    Score Cs;
    public GameObject LoseScreen;
    public GameObject WinScreen;
    private bool  LWScreen = false;
    public delegate void StopIt();
    public static event StopIt StopGame;
    public Button[] buttons;
    void Start()
    {
     
    }
    void FixedUpdate()
    {
     if(GameObject.Find("Time") != null)
     {
      Rt = GameObject.Find("Time").GetComponent<SimpleTimer>();
      RemainingTime = Rt._timeLeft;
     }
    
     if(GameObject.Find("Score") != null)
     {
       Cs = GameObject.Find("Score").GetComponent<Score>();
       CurrentScore = Score.score;
     } 
     if(RemainingTime <= 0)
      {
       Fail();
      }
      if(CurrentScore >= ClaimScore)
      {
       Victory();
      }
     }
    
    public void Fail()
    {
      if(!LWScreen)
      {
       StopGame?.Invoke();
       print("Lose");
       Instantiate(LoseScreen, transform.position,Quaternion.identity);
       LWScreen = true;
      }
    }   
    public void LoadMenu()
    {
     SceneManager.LoadScene(0);
    }
    private void Victory()
    { if(!LWScreen)
      {
         StopGame?.Invoke();
         print("Win");
         Instantiate(WinScreen, transform.position,Quaternion.identity);
         UnLockLevel();
         LWScreen = true;
        //  FindObjectOfType<Hook>().StopPlay();
        //  FindObjectOfType<DestroyScore>().DestroySc();
      }
        
    }
    public void UnLockLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if(currentLevel >= PlayerPrefs.GetInt("level"))
        {
            PlayerPrefs.SetInt("level", currentLevel + 1);
            
        }
    }
    public void LoadNextLevel()
     {
        int currentLevelindex = SceneManager.GetActiveScene().buildIndex;
        int nextLevelIndex = currentLevelindex +1;
         if(nextLevelIndex == SceneManager.sceneCountInBuildSettings)
         {
            nextLevelIndex = 0;
         }
         SceneManager.LoadScene(nextLevelIndex); 
     }
     public void ReloadLevel()
     {
       int currentSceneindex = SceneManager.GetActiveScene().buildIndex;
       SceneManager.LoadScene(currentSceneindex); 
     }
    
}

