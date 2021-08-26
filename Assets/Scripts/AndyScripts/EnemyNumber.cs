using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyNumber : MonoBehaviour
{
    public int number;
    public int arbitrary;
    public string text;
    public Text UItext;
    public PlayerNumber pNumber;
    public bool repeat = true;

    // Start is called before the first frame update
    void Start()
    {
        text = enemyNumber(number);
        UItext.text = text;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && repeat == false)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            // Casts the ray and get the first game object hit
            Physics.Raycast(ray, out hit);
            //Debug.Log("This hit at " + hit.point );
            OnMouseDown();
            repeat = false;
        }
    }

    void OnMouseDown()
    {
        arbitrary = number + pNumber.number;    //attempt at changing PlayerNumber's value through left clicking
        pNumber.text = arbitrary.ToString();
        Debug.Log("Mouse is down");
    }

    private string enemyNumber(int Enumber)
    {
        string textNumber;
        textNumber = Enumber.ToString();
        return textNumber;
    }
}
