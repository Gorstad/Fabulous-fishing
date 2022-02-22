using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook : MonoBehaviour
{
    [SerializeField] float Speed = 0.1f;
    [SerializeField] float TopHook = 1f;
    [SerializeField] float BotHook= -1f;
    float newYpos;
    private bool Spoil = false;
    private bool Play = true;
    private bool SpoilEat;

    void Start()
    { 
        
    }
    void Update()
    {
        if(Play)
        {
          MoveHook(); 
        }
     
    }
    public void MoveHook()
    {   
        if(SystemInfo.deviceType == DeviceType.Desktop)
        {
            Vector2 screeenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screeenPosition);
            float yOffset = Speed * Time.deltaTime;
            float newYpos = worldPosition.y + yOffset;
            if(newYpos < TopHook && newYpos > BotHook)
            {
             transform.position = new Vector2(transform.position.x,newYpos);
            }
            if(worldPosition.y + yOffset > 1.4f && Spoil)
          {
           Spoil = false;
          }
        }
         else if (Input.touchCount > 0)
     {
      Touch touch = Input.GetTouch(0);
      Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
      float yOffset = Speed * Time.deltaTime;
      float newYpos = touchPosition.y + yOffset;
      if (touchPosition.y + newYpos < TopHook && touchPosition.y + newYpos > BotHook) 
        { 
            transform.position = new Vector2(transform.position.x, touchPosition.y + newYpos);
            
        }
        if(touchPosition.y + yOffset > 1.4f && Spoil )
          {
           Spoil = false;
          }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<fishmove>(out fishmove fish) && !Spoil) 
        {
            fish.Catched (this.transform);
            Spoil = true;     
        }
    }
    private void HookActivate()
    {
     print("опа");
     Spoil = false;
    }
    private void StopPlay()
    {
        Play = false;
    }
  
}
