using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    Text textTest;

    /// <summary>
    /// 押されたKeyが正解かどうか判断するメソッド
    /// </summary>
    public void DetermineAnswerCorrect(string pushedKey)
    {
        if(pushedKey == typeKeyQuestion.questionChar.ToString())
        {
            textTest.text = "hoge";
            scoreManager.DisplayScore();
            typeKeyQuestion.SelectRandomQestion();
        }
        else
        {
            textTest.text = "tigau";
        }
    }
}
