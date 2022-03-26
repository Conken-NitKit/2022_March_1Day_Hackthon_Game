using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// スコアに関するクラス
/// </summary>
public class ScoreManager : MonoBehaviour
{
    /// <summary>
    /// スコアの合計値を格納する変数
    /// </summary>
    public int totalScore = 0;
    [SerializeField] Text scoreText;

    /// <summary>
    /// 入力したスコア値を合計スコア変数に加算するメソッド
    /// </summary>
    public void DisplayScore(int scoreValue = 1)
    {
        totalScore += scoreValue;

    }
    private void FixedUpdate()
    {
        scoreText.text = "SCORE: " + totalScore.ToString();
    }

}
