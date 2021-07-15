using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{

    private float tempHealth;
    private float tempResistance;
    public float damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        // if the object has the health script then
        if (other.gameObject.GetComponent<Health>() != null)
            {
                // take the damage from their health pool
                other.gameObject.GetComponent<Health>().health -= damage;

            }
        
    }

}
