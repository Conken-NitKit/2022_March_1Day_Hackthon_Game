using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class TweetButton : MonoBehaviour
{
    [SerializeField]
    ScoreManager scoreManager;

    public void PushTweetButton()
    {
        string esctext = UnityWebRequest.EscapeURL($"あなたのスコアは{scoreManager.totalScore}mです！\n");
        string linkUrl = UnityWebRequest.EscapeURL("https://unityroom.com/games/typincrease \n");
        string tag = UnityWebRequest.EscapeURL("ミンクリース"); 
        var url = "https://twitter.com/intent/tweet?"
            + "text=" + esctext
            + "&url=" + linkUrl
            + "&hashtags=" + tag;
        Debug.Log(url);
        Application.OpenURL(url);
    }
}
