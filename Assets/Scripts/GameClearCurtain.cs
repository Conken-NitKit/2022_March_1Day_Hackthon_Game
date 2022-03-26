using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class GameClearCurtain : MonoBehaviour
{
    public void PushTitleButton()
    {
        this.transform.DOMove(new Vector3(0f, 0f, 0f), 2f).SetDelay(1f).OnComplete(() =>
        {
            SceneManager.LoadScene("Title");
        });
    }
}
