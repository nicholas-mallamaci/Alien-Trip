using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawn : MonoBehaviour
{
    public GameObject platform;
    public float spawnTime;
    public float timeBetweenSpawn;
    public float Times;
    public float y;
    // Update is called once per frame
    void Start()
    {
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
        Instantiate(platform, transform.position + new Vector3(9 * Times, y, 0), transform.rotation);
        Times = Times + 1;
    }
}
