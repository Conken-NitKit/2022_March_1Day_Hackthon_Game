using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
/// <summary>
/// ゲームがスタートしたとき、カーテンを下に移動させるクラス
/// </summary>
public class GameStart : MonoBehaviour
{
    [SerializeField]
    TimeLimit timeLimit;

    [SerializeField]
    TypeKeyQuestion typeKeyQuestion;

    [SerializeField]
    PushedKeyGetter pushedKeyGetter;

    void Start()
    {
        this.transform.DOMove(new Vector3(0f, -11f, 0f), 2f).SetDelay(1f).SetEase(Ease.OutBounce).OnComplete(() =>
        {
            Debug.Log("hoge");
            StartCoroutine(timeLimit.CountDownTime());
            StartCoroutine(pushedKeyGetter.GetPushedKey());
            typeKeyQuestion.SelectRandomQestion();
        }); ;
    }

}
