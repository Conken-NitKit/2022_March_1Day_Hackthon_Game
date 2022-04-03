using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 背景に関するクラス
/// </summary>
public class BackGround : MonoBehaviour
{
    [SerializeField]
    Renderer[] backGroundRenderers;

    int backGroundIndex;

    private void Start()
    {
        backGroundIndex = 0;
    }

    /// <summary>
    /// 背景をだんだん透過していって完全に透明になったら別の背景を透過していくスクリプト
    /// </summary>
    public void MakeTransparentBackGround()
    {
        if(backGroundIndex == backGroundRenderers.Length - 1)
        {
            return;
        }

        backGroundRenderers[backGroundIndex].material.color -= new Color32(0, 0, 0, 3);

        if(backGroundRenderers[backGroundIndex].material.color.a == 0)
        {
            backGroundIndex++;
        }
    }
}
