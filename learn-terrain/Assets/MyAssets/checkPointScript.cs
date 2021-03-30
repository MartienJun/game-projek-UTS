using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPointScript : MonoBehaviour
{
    playerDataScript player;
    
    void OnTriggerEnter(Collider other)
    {
        player = GameObject.FindObjectOfType<playerDataScript>();
        player.checkPoint = gameObject.GetComponent<checkPointScript>();
    }

    public void spawn()
    {
        player.transform.position = transform.position;
    }
}   
