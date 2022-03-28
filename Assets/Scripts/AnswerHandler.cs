using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 正解かどうか判断するクラス
/// </summary>
public class AnswerHandler : MonoBehaviour
{
    [SerializeField]
    private TypeKeyQuestion typeKeyQuestion;

    [SerializeField]
    private ScoreManager scoreManager;

    [SerializeField]
    private TimeLimit timeLimit;

    [SerializeField]
    private BlockManager blockManager;

    /// <summary>
    /// 押されたKeyが正解かどうか判断するメソッド
    /// </summary>
    public void OnAnswer(string pushedKey)
    {
        if(pushedKey == typeKeyQuestion.questionChar.ToString())
        {
            scoreManager.IncreaseScore();
            typeKeyQuestion.SelectRandomQestion();
            blockManager.GenerateBlock();
        }
        else
        {
            timeLimit.ReduceRemainingTime();
        }
    }
}
