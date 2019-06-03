using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameData : MonoBehaviour
{
    public Text text;

    public GameObject wordPrefab;
    public GameObject Est;
    public GameObject Esp;
    public GameObject Fin;
    public GameObject Eng;
    public GameObject Ger;
    public GameObject Swe;
    public GameObject WordBox;

    public bool isActiveCat;
    public bool isActiveWord;
    public string randomWord;
    private GameObject triggeringObj;

    private bool triggering;
    // List<string> categoryList = new List<string> { "Kodu- ja taluloomad", "test" };

    

   public void Start()
    {
       // Programm peab: spawnima sõna.
       //iga sõna mis spawnib peab tulema koos (Lang)isCorrect
       //iga Gameobject ( lipp) peab olema koos bool (lang)isCorrect
       //kontroll kas userInput on correct. Kustutab kui on correct.
       //Skoorib kui on correct ja spawn uus sõna.
       //
       //


        //this.GetComponent<Dropdown>().AddOptions(categoryList);
        int catNr = 1;
        string catName = "Kodu- ja taluloomad";
        string[] esp ={"Perro", "Gato", "Cobaya", "Caballo", "Vaca", "Cerdo", "Hámster", "Conejo", "Rata", "Pez de colores"};
        string[] est = {"Koer", "Kass", "Merisiga", "Hobune", "Lehm", "Siga", "Hamster", "Küülik", "Rott", "Kuldkala"};
        string[] swe = {"Hund", "Katt", "Masvin", "Häst", "Ko", "Svin", "Hamster", "Kanin", "Ratta", "Guldfish"};
        string[] fin ={"Koira", "Kissa", "Marsu", "Hevonen", "Lehmä", "Sika", "Hamsteri", "Kaniini", "Rotta", "Kultakala"};
        string[] eng = {"Dog", "Cat", "Guinea pig", "Horse", "Cow", "Pig", "Hamster", "Rabbit", "Rat", "Goldfish"};
        string[] ger ={ "der Hund", "die Katze", "das Meerschweinchen", "das Pferd", "die Kuh", "das Schwein", "der Hamster", "das Kaninchen", "die Ratte", "der Goldfisch" };
        int randomIndex = Random.Range(0, 10);
        string randomWord = esp[randomIndex];
        string currentWord;
        currentWord = randomWord;
        WordisEsp();
        void WordisSwe()
        {
            bool isEst=false;
            bool isEsp=false;
            bool isSwe=true;
            bool isEng=false;
            bool isFin=false;
            bool isGer=false;

        }
        void WordisEsp()
        {
            bool isEst = false;
            bool isEsp = true;
            bool isSwe = false;
            bool isEng = false;
            bool isFin = false;
            bool isGer = false;

        }

        void WordisEng()
        {
            bool isEst = false;
            bool isEsp = false;
            bool isSwe = false;
            bool isEng = true;
            bool isFin = false;
            bool isGer = false;

        }

        void WordisEst()
        {
            bool isEst = true;
            bool isEsp = false;
            bool isSwe = false;
            bool isEng = false;
            bool isFin = false;
            bool isGer = false;

        }
        void WordisFin()
        {
            bool isEst = false;
            bool isEsp = false;
            bool isSwe = false;
            bool isEng = false;
            bool isFin = true;
            bool isGer = false;

        }
        void WordisGer()
        {
            bool isEst = false;
            bool isEsp = false;
            bool isSwe = false;
            bool isEng = false;
            bool isFin = false;
            bool isGer = true;

        }

        void SetCurrentWord(string x)
        {

            isActiveCat = true;
            isActiveWord=true;
            x = currentWord;
            

        }
       
       
        Debug.Log("sõna on->"+currentWord);
        text.text = currentWord;
        if ( Est==WordBox)

        {
            currentWord = est[2];
        }
        
        
        /*
        string value1 = "okei";
        string value2 = "okei";
        
        bool isCorrect = (value1==value2);
        
        bool activ est 
        jne
        */

        void OnTriggerEnter(Collider2D other)
        {
            if (other.tag =="Lang")
            {
                triggering = true;
                triggeringObj = other.gameObject;
            }
        }

        void Update()
        {
            if (triggering == true)
            {
                Debug.Log(gameObject.name);
                Destroy(WordBox);
            }
        }
    }
    



}

