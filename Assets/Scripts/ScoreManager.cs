using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    /// <summary>
    /// �X�R�A�̍��v�l���i�[����ϐ�
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
