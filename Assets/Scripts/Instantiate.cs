using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject enemy;
    public float tickTimer;
    public float timerEnd;
    public int randomNumber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tickTimer <= 0)
        {
            randomNumber = Random.Range(1, 7);
            Instantiate(enemy, gameObject.transform);
            tickTimer = timerEnd * randomNumber;

        }
        else
        {
            tickTimer--;
        }
    }
}
