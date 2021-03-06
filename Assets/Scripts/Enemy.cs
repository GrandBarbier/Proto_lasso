﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(rb.velocity);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(other);
        
        if (other.collider.tag == "Tilemap" && rb.velocity.magnitude > 10)
        {
            Death();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "hit")
        {
            Death();
        }
    }

    void Death()
    {
        Destroy(gameObject);
    }
}
