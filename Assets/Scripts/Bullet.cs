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
        rigid = GetComponent<Rigidbody2D>();
        rigid.velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.SendMessage("TakeDamage",1.0);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject);
        }

    }
}
