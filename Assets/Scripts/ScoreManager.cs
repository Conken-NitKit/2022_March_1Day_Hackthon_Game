using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// �X�R�A�Ɋւ���N���X
/// </summary>
public class ScoreManager : MonoBehaviour
{
    /// <summary>
    /// �X�R�A�̍��v�l���i�[����ϐ�
    /// </summary>
    public int totalScore = 0;
    [SerializeField] Text scoreText;

    /// <summary>
    /// ���͂����X�R�A�l�����v�X�R�A�ϐ��ɉ��Z���郁�\�b�h
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
