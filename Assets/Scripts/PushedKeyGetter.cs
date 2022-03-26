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

    private float acquisitionKeyIntervalSeconds = 0.005f;

    private string pushedKey;

    private void Start()
    {
        StartCoroutine(GetPushedKey());
    }

    /// <summary>
    /// 押されたKeyを取得するメソッド
    /// </summary>
    private IEnumerator GetPushedKey()
    {
        while (true)
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
