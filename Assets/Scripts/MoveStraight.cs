using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStraight : MonoBehaviour
{


    public float speedOfObject = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(isPlaying == true)
        gameObject.transform.position += gameObject.transform.right * speedOfObject * Time.deltaTime;
    }

}
