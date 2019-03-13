using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPoint : MonoBehaviour
{
    public GameObject Player;
    public Vector3 Myposition;
    public BoxCollider2D Box;
    public SpriteRenderer Sprite;
    public Transform HitPointTransform;
    // Start is called before the first frame update
    void Start()
    {
        Reset();
    }

    // Update is called once per frame
    void Update()
    {
        Myposition = Player.transform.position;
        Myposition.z = 0;
        this.transform.position = Myposition;
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(Burn());
           // Reset();
            //Box.enabled = true;
           // Debug.Log("nyaa");
        }
    }

    IEnumerator Burn()
    {
        Debug.Log("myaaaaaaaaaaa");
        Shot();
        yield return new WaitForSeconds(0.2f);
        Reset();
        Debug.Log("myaaaaaaaaaaa");
    }
    void Shot()
    {
        Box.enabled = true;
        Sprite.enabled = true;
    }
    private void Reset()
    {
        Box.enabled = false;
        Sprite.enabled = false;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "akikan")
        {
            collision.gameObject.GetComponent<akikan>().Hit(HitPointTransform);
            Reset();
        }
    }
}
