using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desk : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.tag = "Desk";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Desk");
        this.gameObject.tag = "Bottom";
    }
}
