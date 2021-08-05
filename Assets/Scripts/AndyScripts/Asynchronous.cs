using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Asynchronous : MonoBehaviour
{
    public bool loadlevel;
    public string levelName;


    // Update is called once per frame
    void Update()
    {
        if (loadlevel == true)
        {
            loadlevel = false; //this is to prevent unity from crashing
            StartCoroutine(AsyncLevel());

            var progress = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive); //this ensures that the scene being overlapped is not deleted like with scenemanager.loadscene
            progress.completed += (op) => Debug.Log("Scene Loaded");
        }
    }

    private IEnumerator AsyncLevel()
    {
        var progress = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive); //this ensures that the scene being overlapped is not deleted like with scenemanager.loadscene

        while (!progress.isDone)
        {
            yield return null;
        }

        Debug.Log("level loaded");
    }

}
