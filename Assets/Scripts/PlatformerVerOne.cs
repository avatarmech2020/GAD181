using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerVerOne : MonoBehaviour
{
    public gameTimer currentGameTimer;
    public GameObject Key;
    private DestroyOnCollide KeyForBox;
    public bool hasKey = false;
    public GameObject Box;

    // Start is called before the first frame update
    void Start()
    {
        KeyForBox = Key.GetComponent<DestroyOnCollide>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(KeyForBox != null)
        {
            if(KeyForBox.readyToDestroy == true)
            {
                KeyForBox.DestroySelf();
                hasKey = true;
                Debug.Log(hasKey);
            }
        }
        if(hasKey == true)
        {
           
        }
    }
}
