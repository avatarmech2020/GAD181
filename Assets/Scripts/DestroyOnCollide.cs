using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollide : MonoBehaviour
{// Update is called once per frame
    public bool CorrectObject;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<CharacterController2D>() == true || other.GetComponent<TopdownCharacterController>() == true)
        {
            
            if (CorrectObject == true)
            {
                Destroy(gameObject);
            }
        }
    }
}