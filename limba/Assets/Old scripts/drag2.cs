using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag2 : MonoBehaviour
{
    Vector2 dist;
    float posX;
    float posY;

    void OnMouseDown()
    {
        dist = Camera.main.WorldToScreenPoint(transform.position);
        posX = Input.mousePosition.x - dist.x;
        posY = Input.mousePosition.y - dist.y;

    }

    void OnMouseDrag()
    {
        Vector2 curPos =
            new Vector2(Input.mousePosition.x - posX,
                Input.mousePosition.y - posY);

        Vector2 worldPos = Camera.main.ScreenToWorldPoint(curPos);
        transform.position = worldPos;
    }
}
