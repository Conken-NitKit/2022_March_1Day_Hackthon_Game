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

    private string questions = "abcdefghijklmnopqrstuvwxyz0123456789";

    public char questionChar { get; private set; }

    private void Start()
    {
        SelectRandomQestion();
    }

    /// <summary>
    /// 問題をランダムで選ぶクラス
    /// </summary>
    public void SelectRandomQestion()
    {
        questionChar = questions[Random.Range(0 , questions.Length)];
        textTest.text = questionChar.ToString();//デバック用
    }
}
