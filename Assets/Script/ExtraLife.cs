using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraLife : MonoBehaviour
{
    LifePoints extraHealt;
    public GameObject pickup1;
    public GameObject ExtraLifeSprite;

    // Start is called before the first frame update
    void Start()
    {
        extraHealt = gameObject.GetComponent<LifePoints>();
    }

    void Update()
    {
        if(extraHealt.healtAmount < 200)
        {
            ExtraLifeSprite.SetActive(false);
        }
    }

        private void OnTriggerEnter2D(Collider2D collisonLife)
    {
        if(collisonLife.tag == "Life")
        {
            ExtraLifeSprite.SetActive(true);
            extraHealt.healtAmount = 200;
            Destroy(collisonLife.gameObject);
        }
    }
}
