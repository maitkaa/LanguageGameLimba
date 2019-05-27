using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class DataLoader : MonoBehaviour
{
   

    void Awake()
    {

        List<Word> MyData = new List<Word>();
        LoadData("data.json");
      
    }
   
   
    public void LoadData(string path)
    {

        string myLoadedItem = JsonFileReader.LoadJsonAsResource(path);
        Debug.Log(myLoadedItem);
      
        RootObject myData = JsonConvert.DeserializeObject<RootObject>(myLoadedItem);
        for (int i = 0; i < 251; i++)
        {
           
            myData.words.Add(myData);
           
        }
       
        Word singleWord = myData.words[0];
        Debug.Log(myData.words.Count);
       ///toimib midagi
    }
}   
