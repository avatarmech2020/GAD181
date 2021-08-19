using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickItemCorrect : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //// when you click left mouse
        //if (Input.GetKeyDown(KeyCode.Mouse0))
        //{
        //    mosPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //    //Debug.Log("clicked");

        //    // if your hovering over an object then
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    //RaycastHit hitInfo = new RaycastHit();
        //    if (Physics.Raycast(ray, out RaycastHit hitInfo))
        //    {
        //        Debug.Log("Hit object");
        //        if (hitInfo.collider.gameObject.tag == "RightItem")
        //        {
        //            Debug.Log("YES");
        //        }
        //    }

        //if (EventSystem.current.IsPointerOverGameObject())
        //{
        //    Debug.Log("YES");
        //}
        //}
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        // when this object is clicked put this code in and destroy the object (because it is a correct selection)
        Debug.Log("That is a clue");
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        // when destroyed add one to the static score of the scoring script

        // TO LATER BE ADDED when the level is complete reset the score
        
    }
}