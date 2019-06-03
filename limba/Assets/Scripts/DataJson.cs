using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
 public class Words
{

    public string catNr;
    public string category; 
    public string wordNr ;
    public string est;
    public string eng;
    public string fin;
    public string esp;
    public string ger;
    public string swe;
}
public class RootObject
{
    public List<Words> words;
}