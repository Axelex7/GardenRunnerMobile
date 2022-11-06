using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCosm : MonoBehaviour
{
    public Sprite none;
    public Sprite duck;
    public Sprite fedora;
    public Sprite crown;
    
    void Start()
    {
        this.gameObject.GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        if (PlayerPrefs.GetInt("EquipC1") == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = duck;
        }
        if (PlayerPrefs.GetInt("EquipC2") == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = fedora;
        }
        if (PlayerPrefs.GetInt("EquipC3") == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = crown;
        }
       
    }
}
