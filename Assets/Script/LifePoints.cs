using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifePoints : MonoBehaviour
{

    public float healtAmount;
    public GameObject player;
    public GameObject laser;
    public GameObject mask;

    public void Update()
    {
        if(healtAmount <= 0)
        {
            Destroy(player);
            Time.timeScale = 0;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if(laser.activeSelf || mask.activeSelf)
        {
            
        }
        else
        {
        if(coll.tag == "Asteroid")
        {
            TakeDamage(100);
        }
        }
    }

    public void TakeDamage(float Damage)
    {
        healtAmount -= Damage;
    }

}
