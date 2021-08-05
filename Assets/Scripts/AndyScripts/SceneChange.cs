using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;                  //this line is necessary to be able to use the scene change line

public class SceneChange : MonoBehaviour
{
    public string[] scenes = new string[4] { "pikachu", "onix", "gengar", "mew" };
    private int number;
    public List<string> sceneNames = new List<string>();


    

    // Start is called before the first frame update
    void Start()
    {
        SelectRandomArray();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SelectRandomArray()
    {
        List<string> newRandomScenes = new List<string>(); // Created an empty list of strings to contain random scene names

        while (newRandomScenes.Count < scenes.Length) //Select 'n' number of games to put into the list 
        {
            int randomGameIndex = Random.Range(0, sceneNames.Count); // Pick random index from initial scene names list
            newRandomScenes.Add(sceneNames[randomGameIndex]); // Add the scene name to the newRandomScenes list
            sceneNames.RemoveAt(randomGameIndex); // Remove scene name from the initial scene names list 
        }

        foreach (string name in newRandomScenes)
        {
            print(name);
        }
    }
}
