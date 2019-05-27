using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;

/*
public class WordGenerator : MonoBehaviour
{
    //private static string[] wordList = {"jalg", "pea", "varvas"};
    private static string jsonString;
   public WordList WordList = new WordList();

   void Start()
   {
        TextAsset asset = Resources.Load("data") as TextAsset;
        if (asset != null)
        {
            WordList = JsonUtility.FromJson<WordList>(asset.text);
            foreach (Word.Words in WordList.Words)
            {
                print();
            }
        }
        else
        {
            print("Asset is null");
        }
   }
    public static string GetRandomWord()
    {
        string fileLocation = System.IO.Path.Combine(Application.streamingAssetsPath, "data.json");
        jsonString = File.ReadAllText(fileLocation);
        WordList sonad = JsonUtility.FromJson<WordList>(jsonString);
        Debug.Log(sonad.swe);
        int randomIndex = Random.Range(0, 9);
        print(sonad.est);
        string randomWord = sonad.est.TrimEnd();
        return randomWord;
    }
   
}
*/