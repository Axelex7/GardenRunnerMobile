using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadMenu()
    {
        Debug.Log("Menu");
        SceneManager.LoadScene("MainMenu");
    }
    public void LoadPlay()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void LoadShop()
    {
        SceneManager.LoadScene("Shop");
    }
}
