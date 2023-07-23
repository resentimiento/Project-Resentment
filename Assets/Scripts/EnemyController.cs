using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public float speed;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    private void FixedUpdate()
    {
        rb.velocity = Vector2.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Point"))
        {
            speed *= -1;
            spriteRenderer.flipX = !spriteRenderer.flipX;
        }

        if (other.transform.CompareTag("Player"))
        {
            Destroy(other.gameObject);
        }


    }

}