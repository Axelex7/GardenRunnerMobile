using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileDestroy : MonoBehaviour
{
    public float Timer = 15;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Timer > 0)
        {
            Timer -= Time.fixedDeltaTime;
        }
        if (Timer <= 0)
        {
            Destroy(gameObject);
        }
    }

    
}
