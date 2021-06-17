using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour
{

    public Vector3 objectPos;
    public Vector3 mousePos;
    public float angle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        objectPos = this.transform.position;


        this.transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(mousePos.y - objectPos.y, mousePos.x - objectPos.x)* Mathf.Rad2Deg);



    }
}
