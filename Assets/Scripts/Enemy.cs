using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static event Action<Enemy> OnEnemyKilled;
    public GameObject prefab;
    [SerializeField] float health, maxHealth = 3f;
    [SerializeField] float moveSpeed = 5f;
    Rigidbody2D rb;
    Transform target;
    Vector2 moveDirection;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    private void Start()
    {
        health = maxHealth;
        target = GameObject.Find("Player").transform;
    }

    private void Update(){
        if(target){
            Vector3 direction = (target.position - transform.position).normalized;
            moveDirection = direction; 
        }
    }

    // Update is called once per Timedframe
    private void FixedUpdate()
    {
        if(target){
            rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * moveSpeed;
        }
    }

    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;
        Debug.Log($"Health: {health}");
        if(health <= 0){
            Instantiate(prefab, new Vector3(13,-7,0),transform.rotation);
            Destroy(gameObject);
            OnEnemyKilled?.Invoke(this);
        }
    }


}
