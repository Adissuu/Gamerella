using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mask : MonoBehaviour
{
    // [SerializeField]
    // public GameObject player;

    // when the GameObjects collider arrange for this GameObject to travel to the left of the screen
    void OnTriggerEnter2D(Collider2D col)
    {
        // if (col.gameObject.name == "Player")
            Debug.Log("Collision");
        // Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
        // spriteMove = -0.1f;
    }
}
