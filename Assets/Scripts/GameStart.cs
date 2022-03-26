using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
/// <summary>
/// ゲームがスタートしたとき、カーテンを下に移動させるクラス
/// </summary>
public class GameStart : MonoBehaviour
{
   
    void Start()
    {
        this.transform.DOMove(new Vector3(0f, -11f, 0f), 2f).SetDelay(1f).SetEase(Ease.OutBounce);
    }

}
