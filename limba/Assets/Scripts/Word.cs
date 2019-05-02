using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word
{
    public string word;
  private WordDisplay display;
    public Word(string _word,WordDisplay _display)
    {
        word = _word;
        display = _display;
       display.SetWord(word);
    }

}
