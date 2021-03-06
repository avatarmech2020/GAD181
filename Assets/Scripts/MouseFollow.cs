using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour
{

    public Vector3 objectPos;
    public Vector3 mousePos;
    public float angle;
    public bool isPlaying;
    public Quaternion transformRotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlaying == true)
        {
            LookAtMouse();
        }


    }

    public void LookAtMouse()
    {
        // gets the position of the mouse and the object position
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        objectPos = this.transform.position;


        // the transform rotation = the rotation equation below which calculates the position between the object and the mouse position 
        this.transform.rotation = transformRotation;
        transformRotation = Quaternion.Euler(0, 0, Mathf.Atan2(mousePos.y - objectPos.y, mousePos.x - objectPos.x) * Mathf.Rad2Deg -90);

    }
}
