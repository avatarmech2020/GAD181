using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAtPlayer : MonoBehaviour
{
    public bool shoot;
    public int timer;
    public int startTimer;
    public GameObject bullet;
    public Vector3 characterLocation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        characterLocation = GameObject.Find("PlayerTopDown").transform.position;

        var currentLocation = Quaternion.Euler(0, 0, Mathf.Atan2(transform.position.y - characterLocation.y, transform.position.x - characterLocation.x) * Mathf.Rad2Deg -180);
        

        if (timer <= 0)
        {
            Instantiate(bullet, transform.position, currentLocation);
            timer = startTimer;

        }
        else
        {
            timer--;
        }
    }

}
