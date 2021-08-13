using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

    //public class Asynchronous : MonoBehaviour
    //{
    //    public bool loadlevel;
    //    public string levelName;


    //    // Update is called once per frame
    //    void Update()
    //    {
    //        if (loadlevel == true)
    //        {
    //            loadlevel = false; //this is to prevent unity from crashing
    //            StartCoroutine(AsyncLevel());

    //            var progress = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive); //this ensures that the scene being overlapped is not deleted like with scenemanager.loadscene
    //            progress.completed += (op) => Debug.Log("Scene Loaded");
    //        }
    //    }

    //    private IEnumerator AsyncLevel()
    //    {
    //        var progress = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive); //this ensures that the scene being overlapped is not deleted like with scenemanager.loadscene

    //        while (!progress.isDone)
    //        {
    //            yield return null;
    //        }

    //        Debug.Log("level loaded");
    //    }

    //}
    public class Asynchronous : MonoBehaviour
    {
        void Update()
        {
            // Press the space key to start coroutine
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // Use a coroutine to load the Scene in the background
                StartCoroutine(LoadYourAsyncScene());
            }
        }

        IEnumerator LoadYourAsyncScene()
        {
            // The Application loads the Scene in the background as the current Scene runs.
            // This is particularly good for creating loading screens.
            // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
            // a sceneBuildIndex of 1 as shown in Build Settings.

            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("async");

            // Wait until the asynchronous scene fully loads
            while (!asyncLoad.isDone)
            {
                yield return null;
            }
        }
    }
