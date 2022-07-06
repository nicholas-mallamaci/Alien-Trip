using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUoRandomSpawn : MonoBehaviour
{
    public GameObject extraLifeRandom;
    public GameObject laserRandom;
    public GameObject maskRandom;
    public float spawnTime1;
    public float timeBetweenSpawn1;
    public float Times1;
    private float randomNumber;
    public float MaxY1;
    public float MinY1;

    // Update is called once per frame
    void Start()
    {
        Times1 = 1;
    }

    void Update()
    {
        if(Time.time > spawnTime1)
        {
            Spawn();
            spawnTime1 = Time.time + timeBetweenSpawn1;
        }
    }

    void Spawn()
    {
        float randomY1 = Random.Range(MinY1, MaxY1);
        randomNumber = Random.Range(0, 3);
        switch(randomNumber)
        {
            case 0: Instantiate(extraLifeRandom, transform.position + new Vector3(75 * Times1, randomY1, 0), transform.rotation); break;
            case 1: Instantiate(maskRandom, transform.position + new Vector3(75 * Times1, randomY1, 0), transform.rotation); break;
            case 2: Instantiate(laserRandom, transform.position + new Vector3(75 * Times1, randomY1, 0), transform.rotation); break;
        }
        Times1 = Times1 + 1;
    }
}
