using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickItem : MonoBehaviour
{
    private Vector3 mosPos;
    private bool isObject;
    public int counting = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // when you click left mouse
        if (Input.GetKey(KeyCode.Mouse1))
        {
            mosPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // if your hovering over an object then
            if (isObject == true)
            {
                // add one to the count
                counting++;
            }

        }

    }
}
