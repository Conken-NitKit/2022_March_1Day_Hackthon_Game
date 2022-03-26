using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testBlock : MonoBehaviour
{

    [SerializeField] GameObject block;
    [SerializeField] BlockManager blockManager;

    

    private void Start()
    {
       
    }



    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            blockManager.GenerateBlock();
        }
    }

}
