using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Newtonsoft.Json;

public class DataLoader : MonoBehaviour
{

    List<Words> MyData = new List<Words>();
    
    void Awake()
    {

        
        LoadData("data.json");
    
    }
   
   
    public void LoadData(string path)
    {

        string myLoadedItem = JsonFileReader.LoadJsonAsResource(path);
        Debug.Log(myLoadedItem);
      
        RootObject myData = JsonConvert.DeserializeObject<RootObject>(myLoadedItem);
        for (int i = 0; i < 250; i++)
        {
            
            //myData.words.Add(myData);
        // Debug.Log(myData.words);
        }
       
        Words singleWord = myData.words[0];
       // Debug.Log(myData.words.Count);
       
    }
}   
