using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mask : MonoBehaviour
{
    public GameObject maskDetect;
    public GameObject pickup2;
    

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collison2)
    {
        if(collison2.tag == "Mask")
        { 
            maskDetect.SetActive(true);
            Destroy(collison2.gameObject);  
        }
    }
}