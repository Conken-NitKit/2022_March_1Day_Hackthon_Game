using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement; 

///<summary>
///スタートボタンを押すとMainGameへ移行するクラス
///</summary>
public class SceneLoader : MonoBehaviour
{
    ///<summary>
    ///スタートボタンを押したときの処理
    ///</summary>
    public void PushStartButton()
    {
        this.transform.DOMove(new Vector3(0f, 0f, 0f), 2f).SetDelay(1f).OnComplete(() =>
        {
            SceneManager.LoadScene("MainGame");
        }); 
    }
}
