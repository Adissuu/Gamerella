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
    }

    void FixedUpdate()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.z = Input.GetAxisRaw("Vertical");
        rigid.transform.position += new Vector3(input.x, input.z, 0) *speed;
    }
    // Update is called once per frame
    void Update()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.z = Input.GetAxisRaw("Vertical");
        Debug.Log(AlmostEquals(input.x, 0.1f, 0.00005));
        // Debug.Log(input.z);
        // Debug.Log(input.x != 0 || input.z != 0);
        if (AlmostEquals(input.x, 0.1f, 0.00005))
            _anim.SetBool("isWalking", false);
        else
        {
            _anim.SetFloat("movX", input.x);
            _anim.SetFloat("movY", input.z);
            _anim.SetBool("isWalking", true);
        }

        rigid.transform.position += new Vector3(input.x, input.z, 0) *speed*Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.Space ))
        {
            GameObject clone = Instantiate(prefab, transform.position, transform.rotation);
        }

    }
}
