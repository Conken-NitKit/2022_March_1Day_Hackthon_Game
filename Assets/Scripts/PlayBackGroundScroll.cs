using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBackGroundScroll : MonoBehaviour
{
    int spriteCount = 3;
    float upOffset = 1.6f;
    float downOffset = -0.6f;

    Transform Trf;
    SpriteRenderer Rndr;
    float height;

    void Start()
    {
        Trf = transform;//Transformの情報
        Rndr = GetComponent<SpriteRenderer>();//背景（スプライト）のサイズ情報
        height = Rndr.bounds.size.y;
    }


    void Update()
    {
        // 座標変換
        Vector3 Viewport = Camera.main.WorldToViewportPoint(Trf.position);
        Debug.Log(Viewport);

        // 背景の回り込み(カメラがy軸プラス方向に移動時)
        if (Viewport.y < downOffset)
        {
            Trf.position += Vector3.up * (height * spriteCount);
        }
        // 背景の回り込み(カメラがy軸マイナス方向に移動時)
        else if (Viewport.y > upOffset)
        {
            Trf.position -= Vector3.up * (height * spriteCount);
        }
    }
}