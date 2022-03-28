using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    /// <summary>
    /// 2D?I?u?W?F?N?g??Block
    /// </summary>
    [SerializeField] GameObject Block;

    private int count = 0;
    private const int Height = 2;


    /// <summary>
    /// ?^?C?v?????????????????u???b?N??????????
    /// </summary>
    public void GenerateBlock()
    {
        Instantiate(Block, new Vector2(0.0f, count * Height), Quaternion.identity);
        count++;
    }
    
}
