using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;//TextMeshProをいじるのに必要

public class ScoreText : MonoBehaviour
{
    public int Score;
    public TextMeshProUGUI Combo_Score_Text;

    public Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        Score_Reset();
        anim = this.gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        Combo_Score_Text.text = Score + "コンボ!";
    }

    void Score_Reset()
    {
        Score = 0;
    }
    public void Score_Add()
    {
        Score++;
        anim.Play();
    }
}
