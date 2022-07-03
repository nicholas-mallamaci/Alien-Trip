using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawn : MonoBehaviour
{

    public GameObject enemy;
    public float spawnTime;
    public float timeBetweenSpawn;
    public float Times;
    public float MaxX;
    public float MaxY;
    public float MinX;
    public float MinY;

    // Update is called once per frame
    void Start()
    {
        Time.timeScale = 1;
        Times = 1;
    }

    void Update()
    {
        if(Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(MinX, MaxX);
        float randomy = Random.Range(MinY, MaxY);

        Instantiate(enemy, transform.position + new Vector3(randomX, randomy, 0), transform.rotation);
        Times = Times + 1;
    }
}
