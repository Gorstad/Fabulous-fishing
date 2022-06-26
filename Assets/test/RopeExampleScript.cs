using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeExampleScript : MonoBehaviour
{
    public GameObject target, samplerope;
    private float step = 0.2f; //шаг веревки
    [SerializeField] float Speed = 0.1f;
    [SerializeField] float TopHook = 1f;
    [SerializeField] float BotHook = -1f;
    private bool Spoil  = false; 
    private Transform CenterPoint;
    public float MaxDistance = 1f;

    // Start is called before the first frame update
    // void Start()
    // {
    //     // определяем вектор нашей цепи
    //     Vector3 tarvec = target.transform.position - transform.position;
    //     // создаем образец звена и помещаем в нужную позицию сдвигаясь на один шаг
    //     GameObject newrope = Instantiate(samplerope, transform.position + 
    //         tarvec.normalized * step, Quaternion.identity);
    //     // получаем доступ к параметрам скрипта звена
    //     RopeNodeExampleScript newrope_rnes = newrope.GetComponent<RopeNodeExampleScript>();
    //     // указываем левую связь
    //     newrope_rnes.lbond = gameObject;
    //     // указываем объект-цель
    //     newrope_rnes.target = target;

    //     // добавляем на объект-источник пружинную связь
    //     SpringJoint2D source_sj = gameObject.AddComponent<SpringJoint2D>();
    //     // эти параметры подбираются экспериментально по вкусу для своей игры
    //     source_sj.frequency = 25;
    //     source_sj.dampingRatio = 0;
    //     // присоединяем к этой связи наше новое звено
    //     source_sj.connectedBody = newrope.GetComponent<Rigidbody2D>();

    //     CenterPoint = GameObject.FindWithTag("Center").GetComponent<Transform>();
    // }
     void Update()
    {
       
        
          MoveHook(); 
        
    }
     public void MoveHook()
    {   
        if(SystemInfo.deviceType == DeviceType.Desktop)
        {
            Vector2 screeenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screeenPosition);
            float yOffset = Speed * Time.deltaTime;
            float newYpos = worldPosition.y + yOffset;
        //    if (newYpos < TopHook && newYpos > BotHook)
              {
               transform.position = Vector2.Lerp(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), Speed);
              }
 
        }
        }    
}

