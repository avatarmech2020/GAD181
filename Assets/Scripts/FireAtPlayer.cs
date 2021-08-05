using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAtPlayer : MonoBehaviour
{
    public bool shoot;
    public int timer;
    public int startTimer;
    public GameObject bullet;
    public Vector3 character;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Quaternion.Euler(0, 0, Mathf.Atan2(transform.position - )

        if (timer <= 0)
        {
            Instantiate(bullet, transform.position, )
            timer = startTimer;

        }
        else
        {
            timer--;
        }
    }
}
