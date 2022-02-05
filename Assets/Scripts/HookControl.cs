using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HookControl : MonoBehaviour
{
    [SerializeField] float Speed = 0.1f;
    [SerializeField] float TopHook = 1f;
    [SerializeField] float BotHook= -1f;
    float newYpos;
    public static float newFpos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
            if(newYpos < TopHook && newYpos > BotHook)
            {
             transform.position = new Vector2(transform.position.x,newYpos);
            }
        }
         else if (Input.touchCount > 0)
     {
      Touch touch = Input.GetTouch(0);
      Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

      if (touchPosition.y + newYpos < TopHook&& touchPosition.y + newYpos > BotHook) 
        { 
            transform.position = new Vector2(transform.position.x, touchPosition.y + newYpos);
        }
     }
    //  yMove = CrossPlatformInputManager.GetAxis("Vertical");
    //  float yOffset = yMove * Speed * Time.deltaTime;
    //  print(yOffset);
    //  float newYpos = transform.localPosition.y + yOffset;
    //  transform.localPosition = new Vector2(transform.localPosition.x, newYpos);
    }
    //  void FixedUpdate()
    //  {
    //      newFpos = transform.position.y;
    //  }
}
