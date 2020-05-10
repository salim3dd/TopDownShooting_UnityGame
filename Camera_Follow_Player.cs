using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow_Player : MonoBehaviour
{
    Transform PlayerPos;
    void Start()
    {
        PlayerPos = GameObject.FindGameObjectWithTag("Player").transform;
    }
   
    void Update()
    {
        transform.position = new Vector3(PlayerPos.transform.position.x, PlayerPos.transform.position.y, -10);
    }
}
