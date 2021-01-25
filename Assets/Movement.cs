using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    

    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var movementA = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementA, 0f,0f ) * Time.deltaTime * speed;
    }

    private void FixedUpdate()
    {
        
    }
}
