using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    Rigidbody2D rigid;
    void Start()
    {
        speed = 5;
        rigid = GetComponent<Rigidbody2D>();
        rigid.velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
