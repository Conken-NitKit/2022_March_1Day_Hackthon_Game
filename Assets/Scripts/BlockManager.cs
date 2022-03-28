using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    /// <summary>
    /// 2D?I?u?W?F?N?g??Block
    /// </summary>
    [SerializeField] GameObject Block;
    [SerializeField] Camera camera;
    [SerializeField] float move;

    private int count = 0;
    private const int Height = 2;

    private void FixedUpdate()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            //GenerateBlock();
            camera.gameObject.transform.position = new Vector3(0, move += 0.5f, -10);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        { 
            //GenerateBlock();
            camera.gameObject.transform.position = new Vector3(0, move -= 0.5f , -10);
        }

    }

    /// <summary>
    /// ?^?C?v?????????????????u???b?N??????????
    /// </summary>
    public void GenerateBlock()
    {
        Instantiate(Block, new Vector2(0.0f, count * Height), Quaternion.identity);
        count++;
    }
    
}
