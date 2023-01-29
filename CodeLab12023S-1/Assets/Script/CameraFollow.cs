using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    
    void Update()
    {
        Vector3 playerPos = player.transform.position;
        //get player pos
        this.gameObject.transform.position = playerPos + new Vector3(0, 2.5f, -6);
        //camera follows at a distance (avoid having to lock rotation)
    }
}
