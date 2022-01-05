using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Text nowScore;
    [SerializeField] Text bestScore;

    public static float score;
    private int intScore;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        AddScore();
        if (GameManager.isGameEnd)
        {
            bestScore.text = intScore.ToString("D5");
        }
    }

    void AddScore()
    {
        if (GameManager.isGameStart)
        {
            score += Time.deltaTime * 15;
            intScore = Mathf.RoundToInt(score);
            nowScore.text = intScore.ToString("D5");
        }
    }
}
