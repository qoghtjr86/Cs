using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text currentScoreUI;
    private int currentScore;

    public Text bestScoreUI;
    private int bestScore;
    // Start is called before the first frame update
    void Start()
    {
        bestScore = PlayerPrefs.GetInt("Best Score", 0);
        bestScoreUI.text = "최고점수 : " + bestScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetScore(int value)
    {
        currentScore = value;
        currentScoreUI.text = "현재점수 : " + currentScore;

        if (currentScore > bestScore)
        {
            bestScore = currentScore;
            bestScoreUI.text = "최고점수 : " + bestScore;
            PlayerPrefs.SetInt("Best Score", bestScore);
        }
    }

    public int GetScore()
    {
        return currentScore;
    }

}
