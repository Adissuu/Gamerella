using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    bool floatUp;
    // Start is called before the first frame update
    void Start()
    {
        floatUp = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (floatUp)
        {
            StartCoroutine(moveUp());
        }
        else
        {
            StartCoroutine(moveDown());
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Scroll");
            Destroy(this.gameObject);
        }
    }
    private IEnumerator moveUp()
    {
        transform.position += new Vector3(0, 1, 0) * 1 * Time.deltaTime;
        yield return new WaitForSeconds(1);
        floatUp = false;
    }
    private IEnumerator moveDown()
    {
        transform.position += new Vector3(0, -1, 0) * 1 * Time.deltaTime;
        yield return new WaitForSeconds(1);
        floatUp = true;
    }
}