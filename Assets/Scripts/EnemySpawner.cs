using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject prefab;

    public GameObject enemy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy == null)
        {
            enemy = Instantiate(prefab, transform.position,transform.rotation, transform);
        }
    }
}
