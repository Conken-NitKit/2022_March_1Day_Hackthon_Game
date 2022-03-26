using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 押されたKeyの管理クラス
/// </summary>
public class PushedKeyGetter : MonoBehaviour
{
    [SerializeField]
    AnswerJudgment answerJudgment;

    [SerializeField]
    TimeLimit timeLimit;

    private float acquisitionKeyIntervalSeconds = 0.001f;

    private string pushedKey;

    /// <summary>
    /// 押されたKeyを取得するメソッド
    /// </summary>
    public IEnumerator GetPushedKey()
    {
        while (timeLimit.limitSeconds >= 0)
        {
            pushedKey = "";
            if (Input.anyKeyDown)
            {
                pushedKey = Input.inputString;
                answerJudgment.DetermineAnswerCorrect(pushedKey);
            }  

            yield return new WaitForSeconds(acquisitionKeyIntervalSeconds);
        }
    }
}
