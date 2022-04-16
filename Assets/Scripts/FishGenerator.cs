using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishGenerator : MonoBehaviour
{
    public GameObject[] CommonFishs;
    public GameObject[] RareFishs;
    public GameObject[] EpicFishs;
    public GameObject Pike;
    // Время спавна обычных рыб
    [SerializeField][Tooltip("минимальное время спавна обычных рыб")] float Cmin = 1f;
    [SerializeField][Tooltip("максимальное время спавна обычных рыб")] float Cmax = 2f;
    // Время спавна редких рыб
    [SerializeField][Tooltip("минимальное время спавна редких рыб")] float Rmin =2f;
    [SerializeField][Tooltip("максимальное время спавна редких рыб")] float Rmax = 3f;
      // Время спавна эпических рыб
    [SerializeField] [Tooltip("минимальное время спавна епических рыб")] float Emin = 3f;
    [SerializeField][Tooltip("максимальное время спавна епических рыб")] float Emax = 4f;
    [SerializeField] float Pmin = 4f;
    [SerializeField] float Pmax = 5f;
    void Start()
    {
      StartCoroutine(createCommFish());
      StartCoroutine(createRareFish());
      StartCoroutine(createEpicFish());
      StartCoroutine(createPike());

    }

    void Update()
    {
     
    }
    // Спавн рыб обычной редкости
      IEnumerator createCommFish()
    {
        yield return new WaitForSeconds (Random.Range (Cmin,Cmax));
        int common = Random.Range(0, CommonFishs.Length);
        GameObject fish = Instantiate(CommonFishs[common]); 
        bool rightFish = Random.Range(0,2) == 1;
        float y = Random.Range(-4.55f,-0.65f);
        float x;
        if(rightFish)
        {
          x = -10.6f;
          fish.GetComponent<fishmove>().movment.x = -0.5f;
          fish.GetComponent<Transform>().Rotate(0f,180f,0f);
        }
        else
        {
          x = 10.6f;
          fish.GetComponent<fishmove>().movment.x = 0.5f;
        }
        fish.GetComponent<Transform>().position = new Vector2(x,y);
        StartCoroutine(createCommFish());
    }
     // Спавн  редких рыб
    IEnumerator createRareFish()
    {
        yield return new WaitForSeconds (Random.Range (Rmin,Rmax));
        int rare = Random.Range(0, RareFishs.Length);
        GameObject fish = Instantiate(RareFishs[rare]); 
        bool rightFish = Random.Range(0,2) == 1;
        float y = Random.Range(-4.55f,-0.65f);
        float x;
        if(rightFish)
        {
          x = -10.6f;
          fish.GetComponent<fishmove>().movment.x = -0.5f;
          fish.GetComponent<Transform>().Rotate(0f,180f,0f);
        }
        else
        {
          x = 10.6f;
          fish.GetComponent<fishmove>().movment.x = 0.5f;
        }
        fish.GetComponent<Transform>().position = new Vector2(x,y);
        StartCoroutine(createRareFish());
    }
    // Спавн  эпических рыб
    IEnumerator createEpicFish()
    {
        yield return new WaitForSeconds (Random.Range (Emin,Emax));
        int epic = Random.Range(0, EpicFishs.Length);
        GameObject fish = Instantiate(EpicFishs[epic]); 
        bool rightFish = Random.Range(0,2) == 1;
        float y = Random.Range(-4.55f,-0.65f);
        float x;
        if(rightFish)
        {
          x = -10.6f;
          fish.GetComponent<fishmove>().movment.x = -0.5f;
          fish.GetComponent<Transform>().Rotate(0f,180f,0f);
        }
        else
        {
          x = 10.6f;
          fish.GetComponent<fishmove>().movment.x = 0.5f;
        }
        fish.GetComponent<Transform>().position = new Vector2(x,y);
        StartCoroutine(createEpicFish());
    }
    // Спавн  Щуки
    IEnumerator createPike()
      {
       yield return new WaitForSeconds (Random.Range(Pmin,Pmax));
   
       GameObject fish = Instantiate(Pike);
       bool rightFish = Random.Range(0,2) == 1;
        float y = Random.Range(-4.55f,-0.6f);
        float x;
        if(rightFish)
        {
          x = -10.6f;
          fish.GetComponent<fishmove>().movment.x = -0.5f;
          fish.GetComponent<Transform>().Rotate(0f,180f,0f);
        }
        else
        {
          x = 10.6f;
          fish.GetComponent<fishmove>().movment.x = 0.5f;
        }
        fish.GetComponent<Transform>().position = new Vector2(x,y);
        StartCoroutine(createPike());
      } 
}
