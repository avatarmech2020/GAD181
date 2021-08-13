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
    public void LoadRanGame()
    {
        
        int index = Random.Range(2, 5);
        SceneManager.LoadScene(index, LoadSceneMode.Additive);
        Debug.Log("scene loaded");

    }
}
