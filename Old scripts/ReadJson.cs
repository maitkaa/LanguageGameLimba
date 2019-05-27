using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using UnityEngine;

[System.Serializable]
public struct Words
{
    public int catNr;
    public string category;
    public int wordNr;
    public string est;
    public string eng;
    public string fin;
    public string esp;
    public string ger;
    public string swe;
}
public class ReadJson : MonoBehaviour
{
    public Words SaveWords;
    void Start()
    {
        SaveWords = JsonUtility.FromJson<Words>(WordJson.LoadJsonFromFile("data.json", false));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
