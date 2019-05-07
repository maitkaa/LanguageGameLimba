using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler


{
    public bool InTheBox = false;
    public GameObject UK, ESP, FIN, WordBox, SWE, EST, GER;
    /*
    void OnTriggerEnter2D(Collider2D col)
    {
        //GameObject WordBox = GameObject.FindGameObjectWithTag("WORD");
        
        if (col.gameObject.tag=="WORD")
        {
            Debug.Log("Eesti tuli");
        }
        
    }
    */

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log(eventData.pointerDrag.name + "asetati" + gameObject.name);

        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (d != null)
        {
            d.parentToReturnTo = this.transform;
            InTheBox = true;

        }



    }

  
}
