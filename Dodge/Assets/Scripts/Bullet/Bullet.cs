using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 0.05f;
    // oncollision인지 판별
    // (충돌의 3가지 상태)enter, stay, exit 중 어느 때 충돌임을 판단할지 설정, enter시점인 걸로
    // ontrigger인지 oncollision인지 선택(트리거) < 보통 리짓바디끼리 충돌 시 콜리전, 둘 중 트리거가 있다면 트리거
    void Start()
    {
        Destroy(gameObject, 6f);
    }

    // Update is called once per frame
    void Update()
    {
           transform.Translate(0f, 0f, bulletSpeed);
    }

    // 공격 입장
}
