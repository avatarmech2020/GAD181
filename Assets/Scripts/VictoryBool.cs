using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryBool : MonoBehaviour
{
    public bool victoryAttained = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        
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

