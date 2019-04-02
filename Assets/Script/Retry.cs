using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//Sceneいじりよう

public class Retry : MonoBehaviour
{
    public GameObject ScoreM;
    public ScoreText ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        ScoreM = GameObject.Find("Canvas/ScoreText");
        ScoreText = ScoreM.GetComponent<ScoreText>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SceneLoad()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Tweet()
    {
        naichilab.UnityRoomTweet.Tweet("akikanhaziki", "アキカンハジキで"+ScoreText.Score+"コンボしました！", "unityroom");
    }
}
