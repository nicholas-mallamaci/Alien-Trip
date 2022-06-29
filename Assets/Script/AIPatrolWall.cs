using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPatrolWall : MonoBehaviour
{

    public float distanceWall;

    private bool movingRight2 = true;

    public Transform wallDetection;
    
    void Update()
    {

        RaycastHit2D wallInfo = Physics2D.Raycast(wallDetection.position, Vector2.right, distanceWall);
        if(wallInfo.collider == true)
        {
            if(movingRight2 == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight2 = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight2 = true;
            }
        }
    }
}
