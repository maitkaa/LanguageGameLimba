using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler

    
{
    public bool InTheBox = false;
    public GameObject UK,ESP,FIN,WordBox,SWE,EST,GER;
    public void InBox()
    {
        //GameObject WordBox = GameObject.FindGameObjectWithTag("WORD");
        
        while (InTheBox == true)
        {
            if (WordBox = EST)
            {
                Debug.Log("EESTI SAI SISSE");
            }
            else if (WordBox = SWE)
            {
                Debug.Log("Swe SAI SISSE");
            }
            else
            {
                Debug.Log("Kao ära pagulane");
            }
            return;
        }
           
        
       
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log(eventData.pointerDrag.name +"asetati" + gameObject.name);

        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (d != null)
        {
            d.parentToReturnTo = this.transform;
            InTheBox = true;
           
        }


        
    }

    
   
}
