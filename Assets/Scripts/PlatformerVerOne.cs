using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerVerOne : MonoBehaviour
{
    public gameTimer currentGameTimer;
    public GameObject Key;
    private DestroyOnCollide KeyForBox;
    public bool hasKey = false;
    public GameObject Lock;
    public GameObject Player;
    public AudioSource backgroundMusic;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<CharacterController2D>())
        {
            Debug.Log("trigger activated");
            if (Lock != null)
            {
                if (hasKey == true)
                {
                    Destroy(this.Lock);
                    Debug.Log("has key");
                    currentGameTimer.TimeText.text = ("Victory");
                    currentGameTimer.timeIsRunning = false;
                    Time.timeScale = 0f;
                    backgroundMusic.Stop();
                }
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        KeyForBox = Key.GetComponent<DestroyOnCollide>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(KeyForBox != null)
        {
            if(KeyForBox.readyToDestroy == true)
            {
                KeyForBox.DestroySelf();
                hasKey = true;
                Debug.Log(hasKey);
            }
        }
        if(currentGameTimer.remainingTime == 0)
        {
            currentGameTimer.TimeText.text = ("You lose");
            Time.timeScale = 0f;
            backgroundMusic.Stop();

        }
        if(Player == null)
        {
            currentGameTimer.timeIsRunning = false;
            currentGameTimer.TimeText.text = ("You lose");
            Time.timeScale = 0f;
            backgroundMusic.Stop();
        }
    }
}
