using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class akikan : MonoBehaviour
{
    public Rigidbody2D rigid2d;
    public int JumpPower;
    public Vector3 Offset;
    // Start is called before the first frame update
    void Start()
    {
        
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
    public void Hit()
    {
        Debug.Log("Hit!!!!!!");
        this.rigid2d.AddForceAtPosition(new Vector2(0, 1) * JumpPower, this.transform.position + Offset);
    }
}
