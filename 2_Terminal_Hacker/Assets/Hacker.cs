using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{

    // Use this for initialization

    void Start()
    {
        ShowMainMenu("Hei på deg");
    }

    void ShowMainMenu(string greeting)
    {
        int lives = 3;
        var userInput = 1;
        Terminal.ClearScreen();
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("Hva vil du hacke?");
        Terminal.WriteLine("Trykk 1 for å hacke mordi");
        Terminal.WriteLine("Trykk 2 for å hacke fardi");
        Terminal.WriteLine("Trykk 3 for å hacke meg");
        Terminal.WriteLine("Ditt valg: ");
    }
    // Update is called once per frame
    void OnUserInput(string input)
    {
        print(input);
        if (input == "1")
        {
            HackMordi();
        }
        else if (input == "2")
        {
            HackFardi();
        }
        else if (input == "3")
        {
            HackMeg();
        }
        else if(input == "menu")
        {
            ShowMainMenu("Hei");
        }
        else
        {
            Terminal.WriteLine("Ugyldig valg");
        }
    }
    void HackMordi()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("ZOMG :--)");
    }
    void HackFardi()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Fardi");
    }
    void HackMeg()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Meg");
    }
}
