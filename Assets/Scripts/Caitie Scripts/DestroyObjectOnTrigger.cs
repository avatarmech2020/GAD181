using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectOnTrigger : MonoBehaviour
{
    
   

    // Update is called once per frame
    void Update()
    {
        function OnTriggerEnter(other : Collider)
 
            if {(other.gameObject.tag == "Player")
                Destroy(this.gameObject);
            }
      
    }
}
