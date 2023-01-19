using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject residuo;
    public Vector3 spawnPoint;
    public int timeTilNextSpawn = 10;
    float timer = 0;

    void Start()
    {
        timer = 0;
    }

    void Update()
    {
        timer += Time.deltaTime;
        Spawn();
    }

    void Spawn()
    {
        if (timer >= timeTilNextSpawn)
        {
            //spawnPoint.x = x;
            Instantiate(residuo, spawnPoint, Quaternion.identity);
            timer = 0;
        }
    }
}
