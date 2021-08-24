using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureHunt : MonoBehaviour
{
    public gameTimer currentGameTimer;
    public GameObject treasureChest;
    private DestroyOnCollide destroyableChest;
    public TopdownCharacterController characterController;
    public AudioSource backgroundMusic;
    public VictoryBool VBool;
   
  


    // Start is called before the first frame update
    void Start()
    {
        destroyableChest = treasureChest.GetComponent<DestroyOnCollide>();
        backgroundMusic = GameObject.FindObjectOfType<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(destroyableChest != null)
        {
            if (destroyableChest.readyToDestroy == true)
            {
                destroyableChest.DestroySelf();
                currentGameTimer.TimeText.text = ("Victory");
                currentGameTimer.timeIsRunning = false;
                Time.timeScale = 0f;
                backgroundMusic.Stop();
                VBool.victoryAttained = true;
               

            }
            if (currentGameTimer.remainingTime == 0)
            {
                currentGameTimer.TimeText.text = ("You lose");
                Time.timeScale = 0f;
                backgroundMusic.Stop();
                VBool.lossLife = true;
            }
        }       
        
    }
}
