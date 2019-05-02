using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragDrop : MonoBehaviour
{
    private bool selected;

    void Update()
    {
        
            if (selected == true)
            {
                Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                transform.position = new Vector2(cursorPos.x, cursorPos.y);
            }

            if (Input.GetMouseButtonUp(0))
            {
                selected = false;
            }
       
        
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            selected = true;
        }
    }
}
