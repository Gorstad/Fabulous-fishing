using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishGenerator : MonoBehaviour
{
    public GameObject[] CommonFishs;
    public GameObject[] RareFishs;
    public GameObject[] EpicFishs;
    // Время спавна обычных рыб
    [SerializeField] float Cmin = 1f;
    [SerializeField] float Cmax = 2f;
    // Время спавна редких рыб
    [SerializeField] float Rmin =2f;
    [SerializeField] float Rmax = 3f;
      // Время спавна эпических рыб
    [SerializeField] float Emin = 3f;
    [SerializeField] float Emax = 4f;
   
    // Start is called before the first frame update
    void Start()
    {
      StartCoroutine(createCommFish());
      StartCoroutine(createRareFish());
      StartCoroutine(createEpicFish());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Создание рыб обычной редкости
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
        // Создание редких рыб
    }
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
    // Создание эпических рыб
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
}
