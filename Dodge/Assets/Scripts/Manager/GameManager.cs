using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{
    // Game Manager ======================
    // 1. 게임이 종료되면 GameOver UI를 보여준다.
    // 2. 재시작 방법을 안내한다.
    public TimerText tmUI;
    public GameOverUI GameOverUI;

    private bool _isOver;
    
    private void Update()
    {
        if(_isOver && Input.GetKeyDown(KeyCode.R))
        {
            // Scene Manager?
            // 우리가 게임을 만들며 생성하게 되는 여러 Scene간의 전환을 돕는 것
            // SceneManager.LoadScene(SceneName or BuildIndex)
            SceneManager.LoadScene(0);
        }
    }

    public void End()
    {
        // 타이머 ui 끔
        tmUI.IsOn = false;

        // 데이터 저장
        //int bestTime = tmUI.SurvivalTime;
        //int savedBestTime = PlayerPrefs.GetInt("BestTime", 0);
        /*
        if(bestTime < savedBestTime)
        {
            bestTime = savedBestTime;
        }
        */
        // 리팩토링
        int savedBestTime = PlayerPrefs.GetInt("BestTime", 0);
        int bestTime = Math.Max(tmUI.SurvivalTime, savedBestTime);
        PlayerPrefs.SetInt("BestTime", bestTime);
        // GameoverUI에 갱신
        GameOverUI.Activate(bestTime);

        // 게임오버 상태 갱신
        _isOver = true;
    }
}
