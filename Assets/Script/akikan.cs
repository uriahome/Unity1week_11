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
    public float ScalePoint;

    public int SpriteNum;
    public Sprite[] MySprite;
    public SpriteRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        SpriteNum = 0;
        renderer = GetComponent<SpriteRenderer>();
        Score_Text = ScoreObj.GetComponent<ScoreText>();
        ScalePoint = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        renderer.sprite = MySprite[SpriteNum];
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
        GetComponent<AudioSource>().Play();//音を再生
        if(SpriteNum == 0)
        {
            SpriteNum = 1;
        }
        Debug.Log("Hit!!!!!!");
        MovePower_X = Mytransform.transform.position.x - Hittransform.transform.position.x;//x座標の差をとる
        MovePower = Base;
        MovePower.x = MovePower_X;
        Score_Text.Score_Add();
        if(Score_Text.Score %5 == 0)
        {
            if(ScalePoint >= 0.10f)
            {
                ScalePoint -= 0.100f;
            }
            else {
                SpriteNum = 2;
                ScalePoint = 0;
            }
        }
        this.transform.localScale = new Vector3(1.0f + ScalePoint, 1.0f + ScalePoint, 1.0f);
        this.rigid2d.AddForceAtPosition(MovePower * JumpPower, this.transform.position + Offset);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bottom")
        {
            Score_Text.GameOver();
            Destroy(this.gameObject);
        }
    }
}
