using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Vector3 input;
    public float speed;
    Rigidbody2D rigid;
    public GameObject prefab;

    private Animator _anim;
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
        rigid.transform.position += new Vector3(input.x, input.z, 0) *speed;
    }
    // Update is called once per frame
    void Update()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.z = Input.GetAxisRaw("Vertical");
        Debug.Log(Input.GetAxisRaw("Horizontal"));
        // Debug.Log(input.z);
        // Debug.Log(input.x != 0 || input.z != 0);
        if ((input.x >= 0.1 && input.x <= -0.1) || (input.z >= 0.1 && input.z <= -0.1))
        {
            _anim.SetFloat("movX", input.x);
            _anim.SetFloat("movY", input.z);
            _anim.SetBool("isWalking", true);
        }
        else
        {
            _anim.SetBool("isWalking", false);
        }

        rigid.transform.position += new Vector3(input.x, input.z, 0) *speed*Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.Space ))
        {
            GameObject clone = Instantiate(prefab, transform.position, transform.rotation);
        }

    }
}
