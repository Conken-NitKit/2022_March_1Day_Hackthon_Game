using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 制限時間に関するクラス
/// </summary>
public class TimeLimit : MonoBehaviour
{
    public float limitSeconds { get; private set; } = 60;

    [SerializeField]
    private float timeCountWaitSeconds;

    [SerializeField]
    private Text timeText;

    [SerializeField]
    private GameClear gameClear;

    /// <summary>
    /// 制限時間を減らしていくメソッド
    /// </summary>
    public IEnumerator CountDownTime()
    {
        while(limitSeconds >= 0)
        {
            limitSeconds -= timeCountWaitSeconds;
            timeText.text = "残り時間 : " + limitSeconds.ToString("F2");
            yield return new WaitForSeconds(timeCountWaitSeconds);
        }
        timeText.text = "残り時間 : 0.00";
        gameClear.ShowGameClearObjects();
    }

    /// <summary>
    /// 制限時間を強制的に減らすメソッド、間違えた時などに使用
    /// </summary>
    public void ReduceRemainingTime(float seconds = 0.5f)
    {
        limitSeconds -= seconds;
    }
}
