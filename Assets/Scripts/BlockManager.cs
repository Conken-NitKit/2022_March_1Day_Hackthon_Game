using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    
    /// <summary>
    /// 2DオブジェクトのBlock
    /// </summary>
    [SerializeField] GameObject Block;
    [SerializeField] Camera camera;

    private int count = 0;
    private const int Height = 2;

    float blockPositionY = 10.0f;

    Transform myTransform;
    private void Start()
    {
        //Vector2 pos = myTransform.position;
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            GenerateBlock();
        }
    }

    /// <summary>
    /// タイプが成功したときにブロックを生成する
    /// </summary>
    public void GenerateBlock()
    {
        Instantiate(Block, new Vector2(0.0f, count * Height), Quaternion.identity);
        count++;
        camera.gameObject.transform.position = new Vector3(0, count*Height, 0);

    }
    
}
