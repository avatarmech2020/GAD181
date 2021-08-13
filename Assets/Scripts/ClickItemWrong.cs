using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickItemWrong : MonoBehaviour, IPointerClickHandler
{
    
    // Start is called before the first frame update

    // To have the wrong item do something


    public void OnPointerClick(PointerEventData eventData)
    {
        // when clicked on type this debug log
        Debug.Log("Thats not a clue");

        
    }
}
