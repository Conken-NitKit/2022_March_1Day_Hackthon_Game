using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PushedKeyGetter : MonoBehaviour
{
    [SerializeField]
    Text textTest;

    private float acquisitionIntervalSeconds = 0.005f;

    private string keyStr;

    private void Start()
    {
        StartCoroutine(GetPushedKey());
    }

    private IEnumerator GetPushedKey()
    {
        while (true)
        {
            keyStr = "";
            if (Input.anyKeyDown)
            {
                keyStr = Input.inputString;
                textTest.text = keyStr.ToLower();
            }
            yield return new WaitForSeconds(acquisitionIntervalSeconds);
        }
    }
}
