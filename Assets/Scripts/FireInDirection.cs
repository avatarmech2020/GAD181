using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireInDirection : MonoBehaviour
{

    public GameObject createdSprite;
    public Transform spawnPos;
    public float distancePlaced;
    public Vector3 objectPos;
    public Vector3 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            objectPos = this.transform.position;


            var rotation = Quaternion.Euler(0, 0, Mathf.Atan2(mousePos.y - objectPos.y, mousePos.x - objectPos.x) * Mathf.Rad2Deg);

            Instantiate(createdSprite, spawnPos.position, rotation);
        }
        
    }



}
