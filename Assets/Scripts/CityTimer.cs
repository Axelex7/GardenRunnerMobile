using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityTimer : MonoBehaviour
{
    public GameObject City;
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
        if (timer < 14)
        {
            timer += Time.fixedDeltaTime;
        }
        if (timer >= 14)
        {
            timer = 0;
            Instantiate(City, spawn.position, transform.rotation);
        }
    }
}
