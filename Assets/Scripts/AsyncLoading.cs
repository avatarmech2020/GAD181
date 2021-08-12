using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AsyncLoading : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
       StartCoroutine(LoadSceneAsync());
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Additive);


    }

    // Update is called once per frame
    IEnumerator LoadSceneAsync()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("AsyncLoading");
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

}
