using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStraight : MonoBehaviour
{


    public float speedOfObject = 10;
    public bool isStarting;
    private int i;
    // Start is called before the first frame update
    void Start()
    {
        isStarting = true;
        i = 50;
    }

    // Update is called once per frame
    void Update()
    {
        //if(isPlaying == true)
        if (isStarting)
        {
            gameObject.transform.position += gameObject.transform.right * 3 * Time.deltaTime;
            if(i >= 0)
            {
                i--;
            }
            if(i <= 0)
            {
                isStarting = false;
            }
        }
        else
        gameObject.transform.position += gameObject.transform.right * speedOfObject * Time.deltaTime;
    }

}
