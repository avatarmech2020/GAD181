using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageAndDestroy : MonoBehaviour
{

    public float damage;
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
        if (other.gameObject.GetComponent<Health>() != null)
        {
            // take the damage from their health pool
            other.gameObject.GetComponent<Health>().health -= damage;

            Destroy(gameObject);
        }
    }
}
