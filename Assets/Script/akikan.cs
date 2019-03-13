using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class akikan : MonoBehaviour
{
    public Rigidbody2D rigid2d;
    public int JumpPower;
    public Transform Mytransform;
    public Vector3 Offset;
    public Vector2 Base = new Vector2(0,1);
    public Vector2 MovePower;
    public float MovePower_X;
    public float MovePower_Y;

    public GameObject ScoreObj;
    public ScoreText Score_Text;
    // Start is called before the first frame update
    void Start()
    {
        Score_Text = ScoreObj.GetComponent<ScoreText>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   /* void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Hit!!!!!!");
            this.rigid2d.AddForceAtPosition(new Vector2(0, 1)*JumpPower, this.transform.position + Offset);
        }
    }*/
    public void Hit( Transform Hittransform)
    {
        Debug.Log("Hit!!!!!!");
        MovePower_X = Mytransform.transform.position.x - Hittransform.transform.position.x;//x座標の差をとる
        MovePower = Base;
        MovePower.x = MovePower_X;
        Score_Text.Score_Add();
        this.rigid2d.AddForceAtPosition(MovePower * JumpPower, this.transform.position + Offset);
    }
}
