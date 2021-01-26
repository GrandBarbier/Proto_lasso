using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    public GameObject hitZone;

    public float actualcd;

    public float cd;

    public bool canHit;
    
    void Start()
    {
        hitZone.SetActive(false);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1) && canHit)
        {
            actualcd = cd;
        }

        if (!canHit)
        {
            hitZone.SetActive(true);
        }
        else
        {
            hitZone.SetActive(false);
        }

        if (actualcd > 0)
        {
            actualcd -= Time.deltaTime;
            canHit = false;
        }
        else
        {
            canHit = true;
        }
        
    }
}
