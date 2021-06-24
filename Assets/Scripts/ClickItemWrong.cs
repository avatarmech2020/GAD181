using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickItemWrong : MonoBehaviour, IPointerClickHandler
{
    public static int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Thats not a clue");
        counter++;
        if (counter == 3)
        {
            // initiate gameover screen and move to next
        }
    }
}
