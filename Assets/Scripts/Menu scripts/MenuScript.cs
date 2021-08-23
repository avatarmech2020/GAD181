using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour 
{
    public SceneChange ChangeScene;
    
    public void Start()
    {
        
    }

    public void PlayApp()
    {
        Debug.Log("lolplay");
        // turn on the scene changer script
       // ChangeScene.Start();

    }

   

    public void ExitApp()
    {
        Debug.Log("i quit");

        Application.Quit();
    }

    public void GoToOptions()
    {
        Debug.Log("options");
        SceneManager.LoadScene("Options");
    }

    public void GoToCredits()
    {
        Debug.Log("credits");
        SceneManager.LoadScene("Credits");
    }

}
