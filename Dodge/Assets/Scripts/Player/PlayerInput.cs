using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    // 프로퍼티로 bool 타입의 UP, DOWN, LEFT, RIGHT 만들기
    public bool UP { get; private set; }
    public bool DOWN { get; private set; }
    public bool LEFT { get; private set; }
    public bool RIGHT { get; private set; }
    
    public float X {get; private set;}
    public float Y {get; private set;}

    // Update is called once per frame
    void Update()
    {
        // 이전 값 날리고 기본값으로 초기화
        //UP = DOWN = LEFT = RIGHT = false;
        X = Y = 0f;

        // 현재 프레임의 입력 값을 저장
            X = Input.GetAxis("Horizontal");
            Y = Input.GetAxis("Vertical");
            UP = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W);
            DOWN = Input.GetKey(KeyCode.DownArrow)|| Input.GetKey(KeyCode.S);
            RIGHT = Input.GetKey(KeyCode.RightArrow)|| Input.GetKey(KeyCode.D);
            LEFT = Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey(KeyCode.A);
        
    }
}
