using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseTimer : MonoBehaviour
{
    public GameObject House;
    public Transform spawn;
    public float timer = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FixedUpdate()
    {
        if (timer < 4)
        {
            timer += Time.fixedDeltaTime;
        }
        if (timer >= 4)
        {
            timer = 0;
            Instantiate(House, spawn.position, transform.rotation);
        }
    }
}
