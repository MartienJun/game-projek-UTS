using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDataScript : MonoBehaviour
{
    public checkPointScript checkPoint;

    void Update()
    {
        if(transform.position.y < -2)
        {
            checkPoint.spawn();
        }
    }
}
