using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookTest : MonoBehaviour
{
    public float yMove;
    [SerializeField] float Speed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveHook(yMove);
    }
    public void MoveHook(float InputAxis)
    {
        yMove = InputAxis;
        float yOffset = yMove * Speed * Time.deltaTime;
        print(yOffset);
        float newYpos = transform.localPosition.y + yOffset;
         transform.localPosition = new Vector2(transform.localPosition.x, newYpos);
        
        
    }

}
