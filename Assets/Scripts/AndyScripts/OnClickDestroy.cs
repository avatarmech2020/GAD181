using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickDestroy : MonoBehaviour
{
    public int number;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (number == 2)
            {
                //return number
                Destroy(this);
            }
            else
            { 

            }
        }
    }
}
