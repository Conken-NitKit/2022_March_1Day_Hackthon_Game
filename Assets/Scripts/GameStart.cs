using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

/// <summary>
/// ゲームがスタートしたときの動きの管理クラス
/// </summary>
public class GameStart : MonoBehaviour
{
    [SerializeField]
    private TimeLimit timeLimit;

    [SerializeField]
    private TypeKeyQuestion typeKeyQuestion;

    [SerializeField]
    private PushedKeyGetter pushedKeyGetter;

    void Start()
    {
        this.transform.DOMove(new Vector3(0f, -11f, 0f), 2f).SetDelay(1f).SetEase(Ease.OutBounce).OnComplete(() =>
        {
            StartCoroutine(timeLimit.CountDownTime());
            StartCoroutine(pushedKeyGetter.GetPushedKey());
            typeKeyQuestion.SelectRandomQestion();
        });
    }

}
