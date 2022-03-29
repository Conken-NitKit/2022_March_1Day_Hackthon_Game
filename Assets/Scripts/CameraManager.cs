using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// カメラの管理クラス
/// </summary>
public class CameraManager : MonoBehaviour
{
    private float blockScaleY = 1f;

    /// <summary>
    /// 呼び出すと1ブロック分カメラを移動するメソッド
    /// </summary>
    public void MoveUpPosition()
    {
        this.transform.position += new Vector3(0f, blockScaleY, 0f);
    }
}
