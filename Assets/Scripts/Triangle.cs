using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : MonoBehaviour
{

    Vector3 input;
    public float speed;
    Rigidbody2D rigid;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        input.x = Input.GetAxisRaw("Horizontal");
        input.z = Input.GetAxisRaw("Vertical");
        rigid.transform.position += new Vector3(input.x, input.z, 0) *speed*Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.Space ))
        {
            GameObject clone = Instantiate(prefab, transform.position, transform.rotation);
        }

    }
}
