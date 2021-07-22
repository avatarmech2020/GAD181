using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowingCollision : MonoBehaviour
{
    public float objectSpeed;
    public float slow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {

            objectSpeed = other.gameObject.GetComponent<CharacterController2D>().maxSpeed;
            other.gameObject.GetComponent<CharacterController2D>().maxSpeed = objectSpeed - slow;
        
        }
    }
}
