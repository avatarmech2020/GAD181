using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public float health;
    public float resistance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // if the object health is lower than 0 auto destroy it (in future using an animation first before destroying it)
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
