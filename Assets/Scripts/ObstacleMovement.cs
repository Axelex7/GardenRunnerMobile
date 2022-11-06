using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float Speed = 3;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void FixedUpdate()
    {

        Vector2 pos = transform.position;

        pos.x -= Speed * Time.fixedDeltaTime;

        transform.position = pos;
    }
}
