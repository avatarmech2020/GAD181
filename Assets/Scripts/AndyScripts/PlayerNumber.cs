using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerNumber : MonoBehaviour
{
    public int number;
    public string text;
    public Text UItext;

    // Start is called before the first frame update
    void Start()
    {
        text = enemyNumber(number);
        UItext.text = text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private string enemyNumber(int Enumber)
    {
        string textNumber;
        textNumber = Enumber.ToString();
        return textNumber;
    }
}
