using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryBool : MonoBehaviour
{
    public bool victoryAttained = false;
    public bool lossLife = false;
    public GameObject playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.FindGameObjectWithTag("Player");
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerController = null)
        {
            lossLife = true;
            
        }

        if (victoryAttained)
        {
            victoryBool = true;
        }


    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // enter the level finish zone/object
        if (other.gameObject.tag == "Player")
        {
            
            victoryAttained = true;

            
        }

    }


}

