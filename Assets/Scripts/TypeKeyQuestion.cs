using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 問題を扱うクラス
/// </summary>
public class TypeKeyQuestion : MonoBehaviour
{
    [SerializeField]
    Text textTest; 

    private string questions = " ";

    private char questionChar;

    /// <summary>
    /// 問題をランダムで選ぶクラス
    /// </summary>
    char SelectRandomQestion()
    {
        questionChar = questions[Random.Range(0 , questions.Length)];
        textTest.text = questionChar.ToString();//デバック用
        return questionChar;
    }
}
