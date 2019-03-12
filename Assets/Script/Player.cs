using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 MousePosition;
    public Vector3 NewPositon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        MousePosition = Input.mousePosition;
        NewPositon = Camera.main.ScreenToWorldPoint(MousePosition);
        NewPositon.z = 0;
        this.transform.position = NewPositon;
    }
}
