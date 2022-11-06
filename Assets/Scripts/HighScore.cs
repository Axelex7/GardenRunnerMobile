using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighScore : MonoBehaviour
{
    public TextMeshProUGUI Score;
    public int diamond = 0;
    public int countBeforeDiamond = 0;
    public float ScoreCount = 0;
    public int FScore = 0;

    void Start()
    {
        
    }

    
    void Update()
    {
        Score.text = FScore.ToString();
    }

    private void FixedUpdate()
    {
        if (ScoreCount >= 0)
        {
            ScoreCount += Time.fixedDeltaTime;
        }
        if (ScoreCount >= 1)
        {
            FScore += 1;
            countBeforeDiamond += 1;
            ScoreCount = 0;
        }
        if (countBeforeDiamond == 10)
        {
            PlayerPrefs.SetInt("Diams", PlayerPrefs.GetInt("Diams") + 1);
            PlayerPrefs.Save();
            Debug.Log("+1Diamond");
            countBeforeDiamond = 0;
        }



       
    }
}
