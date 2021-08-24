using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpikeGame : MonoBehaviour
{
    public gameTimer CurrentGameTimer;
    public Transform[] SpawnPoints;
    public AudioSource BackgroundAudio;
    public GameObject IceSpike;
    
    
    public int Index;

    // Start is called before the first frame update
    void Start()
    {
        CurrentGameTimer.timeIsRunning = true;
        BackgroundAudio = GameObject.FindObjectOfType<AudioSource>();
        if(CurrentGameTimer.remainingTime > 0)
        {
            InvokeRepeating("FallingSpikes()", 0.0f, 5.0f);

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        Index = Random.Range(0, SpawnPoints.Length);
        
    }
    public void FallingSpikes()
    {



        
        
    }
}
