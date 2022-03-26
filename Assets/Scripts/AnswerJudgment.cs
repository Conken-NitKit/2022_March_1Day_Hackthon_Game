using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 正解かどうか判断するクラス
/// </summary>
public class AnswerJudgment : MonoBehaviour
{
    [SerializeField]
    TypeKeyQuestion typeKeyQuestion;

    [SerializeField]
    ScoreManager scoreManager;

    [SerializeField]
    TimeLimit timeLimit;

    /// <summary>
    /// 押されたKeyが正解かどうか判断するメソッド
    /// </summary>
    public void DetermineAnswerCorrect(string pushedKey)
    {
        if(pushedKey == typeKeyQuestion.questionChar.ToString())
        {
            scoreManager.IncreaseScore();
            typeKeyQuestion.SelectRandomQestion();
        }
        else
        {
            timeLimit.ReduceRemainingTime();
        }
    }
}
