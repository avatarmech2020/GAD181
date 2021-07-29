using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public float health;
    public float resistance;
    public Animator anim;
    public int timer = 50;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<CharacterController2D>().anim;
    }

    // if the object health is lower than 0 auto destroy it (in future using an animation first before destroying it)
    void Update()
    {
        if (health <= 0)
        {
            anim.Play("Explosion");
            if (timer <= 0)
            {
                Destroy(gameObject);
                Time.timeScale = 0;
            }
            else
            {
                timer--;
            }
            
        }
    }

}
