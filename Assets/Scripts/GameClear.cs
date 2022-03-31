using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameClear : MonoBehaviour
{
    [SerializeField]
    private GameObject[] resultObujects;

    [SerializeField]
    private Text scoreText;

    [SerializeField]
    private ScoreManager scoreManager;

    public void ShowGameClearObjects()
    {
        foreach(GameObject resultObuject in resultObujects)
        {
            resultObuject.SetActive(true); 
        }

        scoreText.text = $"{scoreManager.totalScore}mです！！";
    }
}
