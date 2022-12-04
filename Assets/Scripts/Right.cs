using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.SceneManagement;

public class Right : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI textComponent;
    AudioSource source;
    public AudioClip clip;
    void Start()
    {
        source = GetComponent<AudioSource>();
        source.clip = clip;
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeScene()
    {
        textComponent.text = "You Win!";
    }
    public void ChangeBadScene()
    {
        SceneManager.LoadScene("Entry level");
    }
}
