using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AsyncLoading : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadSceneAsync());

    }
  
    // load main menu over blank scene
    IEnumerator LoadSceneAsync()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("MainMenu");
        if (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

}
