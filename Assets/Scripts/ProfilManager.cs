using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProfilManager : MonoBehaviour
{
    public int Money;
    public TextMeshProUGUI MoneyText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Money = PlayerPrefs.GetInt("Diams");
        MoneyText.text = Money.ToString();
        if (Input.GetKeyDown(KeyCode.X))
        {
            PlayerPrefs.SetInt("Diams", PlayerPrefs.GetInt("Diams") + 1);
            PlayerPrefs.Save();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.SetInt("Cosm1", PlayerPrefs.GetInt("Cosm1") - 1);
            PlayerPrefs.Save();
        }
    }
}
