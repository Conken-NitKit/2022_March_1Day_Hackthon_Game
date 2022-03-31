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
    public int totalScore { get; private set; } = 0;
    [SerializeField] Text scoreText;

    private void Start()
    {
        scoreText.text = "SCORE: " + totalScore.ToString();
    }

    /// <summary>
    /// 入力したスコア値を合計スコア変数に加算するメソッド
    /// </summary>
    public void IncreaseScore(int scoreValue = 1)
    {
        totalScore += scoreValue;
        scoreText.text = "SCORE: " + totalScore.ToString();
    }
}
