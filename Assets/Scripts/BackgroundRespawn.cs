using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRespawn : MonoBehaviour
{
    public GameObject City;
    public GameObject Houses;
    public Transform CityBGPlace;
    public Transform HouseBGPlace;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("House"))
        {
            Instantiate(Houses, HouseBGPlace.position, transform.rotation);
        }
        if (col.gameObject.CompareTag("City"))
        {
            Instantiate(City, CityBGPlace.position, transform.rotation);
        }
    }
}
