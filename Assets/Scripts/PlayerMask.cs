using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMask : MonoBehaviour
{
    [SerializeField]
    public GameObject player;
    
    private bool _isTrigger;
    private SpriteRenderer _rd;

    private void Start()
    {
        _rd = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (_isTrigger && Input.GetAxis("Vertical") > 0)
            _rd.enabled = false;
        else
            _rd.enabled = true;
        if (_isTrigger)
        {
            transform.position = player.gameObject.transform.position;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        _isTrigger = true;
    }
}
