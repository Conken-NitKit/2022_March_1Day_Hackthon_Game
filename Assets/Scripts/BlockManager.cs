using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class BlockManager : MonoBehaviour
{
    [SerializeField]
    private GameObject block;

    private float totalHeight = 0;

    private const float BlockHeight = 2;

    private const float MinPositionX = -1;
    private const float MaxPositionX = 1;

    /// <summary>
    /// ?^?C?v?????????????????u???b?N??????????
    /// </summary>
    public void Generate()
    {
        Instantiate(block, new Vector3(Random.Range(MinPositionX, MaxPositionX) , totalHeight , 10f), Quaternion.identity);
        totalHeight += BlockHeight;
    }
    
}
