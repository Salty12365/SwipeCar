using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float moveSpeed = 0f;
    bool isMove = false;

    Vector2 startPos;
    
    void Start()
    {
        
    }


    void Update()
    {    
        if(isMove.Equals(false))
        {
            if (Input.GetMouseButtonDown(0))
            {
                startPos = Input.mousePosition;
            }

            if (Input.GetMouseButtonUp(0))
            {
                Vector2 endPos = Input.mousePosition;
                float swipeLength = endPos.x - startPos.x;

                if (swipeLength < 0)
                {
                    swipeLength *= -1;
                }
                moveSpeed = swipeLength / 500f;
                isMove = true;
            }


            transform.Translate(moveSpeed, 0, 0);
            moveSpeed *= 0.98f;
            if (moveSpeed <= 0.01f)
            {

                moveSpeed = 0f;
            }
        }
    }   
}
