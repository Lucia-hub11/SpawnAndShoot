using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public GameObject Prefab;

    public Gradient Gradient;
    // Update is called once per frame
    void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.Space))
            SpawnInPlane(10);
    }

    void SpawnInPlane(int n)
    {
        for(int i = 0; i < n; i++)
        {
            float x = Random.Range(-20f, 20f);
            float y = 20;
            float z = Random.Range(-20f, 20f);
            Vector3 pos = new Vector3(x, y, z);
            Quaternion rot = Random.rotation;
            float s = Random.Range(0.5f, 4f);
            Vector3 size = new Vector3(s, s, s);
            SpawnOne(pos, rot, size);
        }
    }
    private void SpawnMany(int n)
    {
        //Vector3 pos = transform.position;
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < n; j++)
        //    {
        //        if(ShouldSpawn())
        //            SpawnOne(pos);
        //        pos.x += 1;
        //    }
        //    pos.x = transform.position.x;
        //    pos.y += 1;
        //}
    }
    public float FillValue = 0.9f;

    private bool ShouldSpawn()
    {
        return Random.value <  FillValue;
    }

    private void SpawnOne(Vector3 pos, Quaternion rot, Vector3 size)
    {
        GameObject go = Instantiate(Prefab, pos, rot);
        go.GetComponent<Renderer>().material.color = Gradient.Evaluate(Random.value)/*new Color(Random.value, Random.value, Random.value)*/;
        go.transform.localScale = size;
    }
    private void SpawnOne()
    {
        Instantiate(Prefab, transform.position, Quaternion.identity);
    }

    private void Move()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time) * 5, 0, 0);
    }
}
