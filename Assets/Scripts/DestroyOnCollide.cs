using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollide : MonoBehaviour
{// Update is called once per frame
    public bool CorrectObject;
    public bool readyToDestroy = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<CharacterController2D>() == true || other.GetComponent<TopdownCharacterController>() == true)
        {
            
            if (CorrectObject == true)
            {
                readyToDestroy = true;
            }
        }
    }

    public void DestroySelf()
    {
        Destroy(this.gameObject);
        
    }
    // add this to script that runs the game
     // if (destroyableChest.readyToDestroy == true)
       // {
         //   destroyableChest.DestroySelf();
        //}
}