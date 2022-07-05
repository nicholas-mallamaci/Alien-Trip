using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidLife : MonoBehaviour
{
    public float healt;
    public GameObject asteroid;

    public void Update()
    {
        if(healt <= 0)
        {
            Destroy(asteroid);
        }
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Laser")
        {
            TakeDamag(100);
        }
    }

    public void TakeDamag(float Damag)
    {
        healt -= Damag;
    }
}
