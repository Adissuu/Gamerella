using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Right : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI textComponent;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeScene()
    {
        textComponent.text = "You Win!";
    }
}
