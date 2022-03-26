using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 制限時間に関するクラス
/// </summary>
public class TimeLimit : MonoBehaviour
{
    [SerializeField]
    private float limitSeconds;

    [SerializeField]
    private float timeCountWaitSeconds;

    [SerializeField]
    private Text timeTest;

    /// <summary>
    /// 制限時間を減らしていくメソッド
    /// </summary>
    public IEnumerator CountDownTime()
    {
        while(limitSeconds >= 0)
        {
            limitSeconds -= timeCountWaitSeconds;
            timeTest.text = "残り時間 : " + limitSeconds.ToString("F2");
            yield return new WaitForSeconds(timeCountWaitSeconds);
        }
        timeTest.text = 0.ToString("F2");
    }

    /// <summary>
    /// 制限時間を強制的に減らすメソッド、間違えた時などに使用
    /// </summary>
    public void ReduceRemainingTime(float seconds = 0.5f)
    {
        limitSeconds -= seconds;
    }
}
