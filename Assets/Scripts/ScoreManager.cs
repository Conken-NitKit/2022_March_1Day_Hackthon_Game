using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    /// <summary>
    /// スコアの合計値を格納する変数
    /// </summary>
    public int totalScore = 0;
    public Text scoreText;

    public void DisplayScore(int scoreValue = 1)
    {
        totalScore += scoreValue;

    }
    private void FixedUpdate()
    {
        scoreText.text = "SCORE: " + totalScore.ToString();
    }

}
