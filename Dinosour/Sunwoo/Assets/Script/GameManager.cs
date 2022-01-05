using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool isGameStart = false;
    public static bool isGameEnd = false;
    public static bool isGameRestart = false;

    [SerializeField] GameObject RestartButton;

    private void Start()
    {
        Time.timeScale = 0;
    }

    private void Update()
    {
        GameStart();
        GameEnd();
    }

    private void GameStart()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isGameStart = true;
            Time.timeScale = 1;
        }
    }

    public void GameEnd()
    {
        if (isGameEnd)
        {
            Time.timeScale = 0;
            isGameStart = false;
            RestartButton.SetActive(true);
        }
    }
    public void GameRestart()
    {

        isGameRestart = true;
        isGameStart = true;
        isGameEnd = false;
        Score.score = 0;
        Time.timeScale = 1;
        RestartButton.SetActive(false);
        isGameRestart = false;

    }



}
