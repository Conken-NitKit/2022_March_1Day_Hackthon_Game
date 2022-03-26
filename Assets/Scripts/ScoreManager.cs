using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ?X?R?A?????????N???X
/// </summary>
public class ScoreManager : MonoBehaviour
{
    /// <summary>
    /// ?X?R?A?????v?l???i?[????????
    /// </summary>
    public int totalScore { get; private set; } = 0;
    [SerializeField] Text scoreText;

    private void Start()
    {
        scoreText.text = "SCORE: " + totalScore.ToString();
    }

    /// <summary>
    /// ?????????X?R?A?l?????v?X?R?A?????????Z???????\?b?h
    /// </summary>
    public void IncreaseScore(int scoreValue = 1)
    {
        totalScore += scoreValue;
        scoreText.text = "SCORE: " + totalScore.ToString();
    }
}
