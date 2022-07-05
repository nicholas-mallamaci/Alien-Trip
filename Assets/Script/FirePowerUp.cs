using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirePowerUp : MonoBehaviour
{
    public GameObject laser;
    public GameObject pickup;
    public AudioSource audioData;
 

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collison)
    {
        if(collison.tag == "Laser")
        { 
            audioData.Play(); 
            laser.SetActive(true);
            Destroy(pickup);
            
        }
    }
}