using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    bool AlmostEquals(double double1, double double2, double precision)
    {
        return (Math.Abs(double1 - double2) <= precision);
    }
    Vector3 input;
    public float speed;
    Rigidbody2D rigid;
    public GameObject prefab;

    public Animator _anim;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.z = Input.GetAxisRaw("Vertical");
        _anim.SetFloat("movY", input.z);
        _anim.SetFloat("movX", input.x);
        if (input.z != 0 || input.x != 0)
        {
            _anim.SetBool("isWalking", true);

        }
        else
        {
            _anim.SetBool("isWalking", false);
        }
        rigid.transform.position += new Vector3(input.x, input.z, 0) *speed;
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space ))
        {
            GameObject clone = Instantiate(prefab, transform.position, transform.rotation);
        }


    }
    public void Riddle()
    {
        Debug.Log("Riddle");
    }
}
