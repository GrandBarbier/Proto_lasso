using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D rb;

    public Text veloText;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(rb.velocity);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Tilemap" && rb.velocity.magnitude > 10)
        {
            Death();
        }
    }

    void Death()
    {
        Destroy(gameObject);
    }
}
