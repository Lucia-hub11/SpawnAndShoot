using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject Prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
            ShouldShoot();
    }

    private void ShouldShoot()
    {
       SpawnBullet();
    }

    private void SpawnBullet()
    {
        Instantiate(Prefab, transform.position, Quaternion.identity);
    }
}
