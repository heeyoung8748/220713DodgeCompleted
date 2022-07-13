using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public void Die()
    {
        // 게임 오브젝트를 삭제
        gameObject.SetActive(false);
        FindObjectOfType<GameManager>().End(); // 차후 싱글톤패턴으로 확장시킬 것
    }

    // 피격 입장
    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "Bullet")
        {
            Die();
            Debug.Log($"[OnTriggerEnter] Me: {gameObject.name}, Other : {other.name}");
        }
       /*
        if(null == other.GetComponent<Bullet>()) // getcomponent가 bullet이라면 가져온 것, 아니면 null
        {
            // 충돌한 other가 bullet이 아님
            return;
        }
        // or  other.tag == "bullet";
        Die();
       */
    }
}
