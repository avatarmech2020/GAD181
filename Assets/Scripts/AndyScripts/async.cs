using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class async : MonoBehaviour
{
    public bool loadlevel;
    public string levelName;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(loadlevel == true)
        {
            SceneManager.LoadScene(levelName, LoadSceneMode.Additive);
        }
    }
}
