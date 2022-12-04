using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Riddle : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    private int index;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
        Debug.Log("asdf");

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)){
            if(textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }
    void StartDialogue(){
        index = 0;
        StartCoroutine(TypeLine());
    }
    IEnumerator TypeLine(){
        foreach (char c in lines[index].ToCharArray()){
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
    void NextLine()
    {
        if(index< lines.Length-1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else{
            gameObject.SetActive(false);
            button1.SetActive(true);
            button2.SetActive(true);
            button3.SetActive(true);
        }
    }
}
