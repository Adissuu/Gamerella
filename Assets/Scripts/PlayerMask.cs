using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMask : MonoBehaviour
{
    [SerializeField]
    public GameObject player;

    [SerializeField]
    public Sprite profile_mask;
    public Sprite default_mask;
    
    
    private Vector3 scale_profile_mask;
    private Vector3 scale_default_mask;
    private bool _isTrigger;
    private SpriteRenderer _rd;
    private Vector3 input;

    private void Start()
    {
        scale_default_mask = transform.localScale;
        scale_profile_mask = new Vector3(6.5f, 6.5f, 6.5f);
        _rd = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");

        // Debug.Log(AlmostEquals(input.x, 0.1f, 0.00005));
        if (_isTrigger && input.x >= 0.00000001 || input.x <= -0.000001)
        {
            _rd.sprite = profile_mask;
            transform.localScale = scale_profile_mask;
            if (input.x < 0)
                _rd.flipX = true;
            else
                _rd.flipX = false;
        }
        else
        {
            _rd.sprite = default_mask;
            transform.localScale = scale_default_mask;
        }
        if (_isTrigger && input.y > 0.00000001)
            _rd.enabled = false;
        else
            _rd.enabled = true;
        if (_isTrigger)
        {
            transform.position = player.gameObject.transform.position;
            if (input.x >= 0.000001)
                transform.position += new Vector3(0.3f, 0, 0);
            else if (input.x <= -0.0000001)
                transform.position += new Vector3(-0.3f, 0, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        _isTrigger = true;
    }
}
