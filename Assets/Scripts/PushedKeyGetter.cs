using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 押されたKeyの管理クラス
/// </summary>
public class PushedKeyGetter : MonoBehaviour
{
    [SerializeField]
    AnswerHandler answerHandler;

    [SerializeField]
    TimeLimit timeLimit;

    private float acquisitionKeyIntervalSeconds = 0.001f;//タイプのチェックスパン

    private string pushedKey;

    /// <summary>
    /// 押されたKeyを取得するメソッド
    /// </summary>
    public IEnumerator GetPushedKey()
    {
        while (timeLimit.limitSeconds >= 0)
        {
            //pushedKey = "";
            if (Input.anyKeyDown)
            {
                pushedKey = Input.inputString;
                answerHandler.OnAnswer(pushedKey);
            }  

            yield return new WaitForSeconds(acquisitionKeyIntervalSeconds);
        }
    }
}
