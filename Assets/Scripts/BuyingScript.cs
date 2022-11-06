using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyingScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.SetInt("Cosm1", 0);
            PlayerPrefs.SetInt("Cosm2", 0);
            PlayerPrefs.SetInt("Cosm3", 0);
            PlayerPrefs.SetInt("EquipC1", 0);
            PlayerPrefs.SetInt("EquipC2", 0);
            PlayerPrefs.SetInt("EquipC3", 0);
            PlayerPrefs.Save();
        }
    }

    public void Buying20()
    {
        if (PlayerPrefs.GetInt("Cosm1") == 0)
        {
            if (PlayerPrefs.GetInt("Diams") >= 20)
            {
                PlayerPrefs.SetInt("Diams", PlayerPrefs.GetInt("Diams") - 20);
                PlayerPrefs.SetInt("Cosm1", PlayerPrefs.GetInt("Cosm1") + 1);
                PlayerPrefs.Save();
                Debug.Log(PlayerPrefs.GetInt("Cosm1"));
            }
        }
        if (PlayerPrefs.GetInt("Cosm1") == 1)
        {
            Debug.Log("equiped");
            PlayerPrefs.SetInt("EquipC1", 1);
            PlayerPrefs.SetInt("EquipC2", 0);
            PlayerPrefs.SetInt("EquipC3", 0);
            PlayerPrefs.Save();
        }
    }
    public void Buying202()
    {
        if (PlayerPrefs.GetInt("Cosm2") == 0)
        {
            if (PlayerPrefs.GetInt("Diams") >= 20)
            {
                PlayerPrefs.SetInt("Diams", PlayerPrefs.GetInt("Diams") - 20);
                PlayerPrefs.SetInt("Cosm2", PlayerPrefs.GetInt("Cosm2") + 1);
                PlayerPrefs.Save();
                Debug.Log(PlayerPrefs.GetInt("Cosm2"));
            }
        }
        if (PlayerPrefs.GetInt("Cosm2") == 1)
        {
            Debug.Log("equiped");
            PlayerPrefs.SetInt("EquipC1", 0);
            PlayerPrefs.SetInt("EquipC2", 1);
            PlayerPrefs.SetInt("EquipC3", 0);
            PlayerPrefs.Save();
        }
    }
    public void Buying50()
    {
        if (PlayerPrefs.GetInt("Cosm3") == 0)
        {
            if (PlayerPrefs.GetInt("Diams") >= 50)
            {
                PlayerPrefs.SetInt("Diams", PlayerPrefs.GetInt("Diams") - 50);
                PlayerPrefs.SetInt("Cosm3", PlayerPrefs.GetInt("Cosm3") + 1);
                PlayerPrefs.Save();
                Debug.Log(PlayerPrefs.GetInt("Cosm3"));
            }
        }
        if (PlayerPrefs.GetInt("Cosm3") == 1)
        {
            Debug.Log("equiped");
            PlayerPrefs.SetInt("EquipC1", 0);
            PlayerPrefs.SetInt("EquipC2", 0);
            PlayerPrefs.SetInt("EquipC3", 1);
            PlayerPrefs.Save();
        }
    }
}
