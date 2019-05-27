using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCol : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        //GameObject WordBox = GameObject.FindGameObjectWithTag("WORD");
        for (int i = 1; i < 6; i++)
        {
            if (col.transform.gameObject.tag == "WORD")
            {
                Debug.Log("tuli külla :" + gameObject.name);

            }
        }


    }

    public void checkCount ()
        {


        }
}
