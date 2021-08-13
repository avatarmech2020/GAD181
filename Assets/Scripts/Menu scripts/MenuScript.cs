using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public void PlayApp()
    {
        // turn on the scene changer script
    }
    public void ExitApp()
    {
        Debug.Log("i quit");

        Application.Quit();
    }

}
