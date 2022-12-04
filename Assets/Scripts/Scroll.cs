using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    bool floatUp;
    private GameObject player;
    private GameObject dialogue;
    // Start is called before the first frame update
    void Start()
    {
        floatUp = true;
        player = GameObject.Find("Player");
        dialogue = GameObject.Find("Text (TMP)");
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
            player.SendMessage("Riddle");
            dialogue.SendMessage("StartDialogue");
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
