using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadAsync : MonoBehaviour
{
    public SceneChange sceneChange;
    void Start()
    {
        
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Additive);
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {  
            StartCoroutine(LoadSceneAsync());
        }
    }
    // load main menu over blank scene
    IEnumerator LoadSceneAsync()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("AsyncLoading");
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

}

