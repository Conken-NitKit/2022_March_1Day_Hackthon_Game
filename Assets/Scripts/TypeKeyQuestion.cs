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
    Text questionTest; 

    private string questions = "abcdefghijklmnopqrstuvwxyz0123456789";

    public char questionChar { get; private set; }

    /// <summary>
    /// 問題をランダムで選ぶクラス
    /// </summary>
    public void SelectRandomQestion()
    {
        questionChar = questions[Random.Range(0 , questions.Length)];
        questionTest.text = questionChar.ToString();
    }
}
