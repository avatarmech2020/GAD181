using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    // the score the player will see
    public int scoreWins;
    public int scoreLoss;
    public bool tick;
    public VictoryBool victoryBool;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (victoryBool.victoryAttained && !tick)
        {
            tick = true;
            //call apon level pick
            Debug.Log("I HAVE CHANGED THE DAMN THING CALLED BOY");
            scoreWins++;
            // timescale to possibly be phased out
            Time.timeScale = 0;
        }

        if (victoryBool.lossLife && !tick)
        {
            tick = true;
            // call apon scene changer and add one to loss score
            Debug.Log("you lost");
            scoreLoss++;
            // timescale to possibly be phased out
            Time.timeScale = 0;
        }
    }

    private void OnLevelWasLoaded(int level)
    {
        tick = false;
        victoryBool.lossLife = false;
        victoryBool.victoryAttained = false;
    }
}
