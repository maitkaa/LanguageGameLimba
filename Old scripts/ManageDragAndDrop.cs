using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageDragAndDrop : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// Keeled on:
    /// Lang1= Est
    /// Lang2= Esp
    /// Lang3= Fin
    /// Lang4= Ger
    /// Lang5= Swe
    /// Lang6= UK
    /// </summary>
    public void Drag()
    {
        //Store the position of the mouse and move the object image.
       // for (var i = 1; i <=6; i++)
       // {
            GameObject.Find("Lang").transform.position = Input.mousePosition;
            print("we are dragging the mouse");
       // }
        
    }

    public void Drop()
    {
        //for (int i = 0; i < 6; i++)
       // {
            GameObject ph1 = GameObject.Find("PlaceHolder1");
            float distance = Vector3.Distance(GameObject.Find("Lang1").transform.position, ph1.transform.position);

            if (distance < 50)
            {
                GameObject.Find("Image").transform.position = ph1.transform.position;
                print("kätte sain");
          //  }
        }
        
    }

}
