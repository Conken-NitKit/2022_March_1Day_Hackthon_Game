using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    [SerializeField]
    Renderer[] backGroundRenderers;

    int backGroundIndex;

    private void Start()
    {
        backGroundIndex = 0;
    }

    public void MakeTransparentBackGround()
    {
        if(backGroundIndex == backGroundRenderers.Length - 1)
        {
            return;
        }

        backGroundRenderers[backGroundIndex].material.color -= new Color32(0, 0, 0, 5);

        if(backGroundRenderers[backGroundIndex].material.color.a == 0)
        {
            backGroundIndex++;
        }
    }
}
