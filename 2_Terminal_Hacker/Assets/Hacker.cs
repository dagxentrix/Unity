
using UnityEngine;

public class Hacker : MonoBehaviour
{
    string[] level1Passwords = { "hest", "katt", "hund", "dyr", "struts", "ekorn" };
    string[] level2Passwords = { "mobil", "ipad", "pc", "tv", "skjerm", "kjøleskap" };
    string[] level3Passwords = { "hus", "enebolig", "rekkehus", "blokk", "leilighet", "villa" };


    // Game state
    int level;
    enum Screen { MainMenu, Password, Win };
    Screen currentScreen;
    string password;
    int lives;

    // Use this for initialization

    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;
        lives = 3;
        var userInput = 1;
        Terminal.ClearScreen();

        Terminal.WriteLine("Hva vil du hacke?");
        Terminal.WriteLine("Trykk 1 for å hacke mordi");
        Terminal.WriteLine("Trykk 2 for å hacke fardi");
        Terminal.WriteLine("Trykk 3 for å hacke meg");
        Terminal.WriteLine("Ditt valg: ");
    }
    // Update is called once per frame


    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }
    }



    void RunMainMenu(string input)
    {
        bool isValidLevel = (input == "1" || input == "2" || input == "3");
        if (isValidLevel)
        {
            level = int.Parse(input);
            StartGame();
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        switch (level)
        {
            case 1:
                password = level1Passwords[Random.Range(0, level1Passwords.Length)];
                break;
            case 2:
                password = level2Passwords[Random.Range(0, level2Passwords.Length)];
                break;
            case 3:
                password = level3Passwords[Random.Range(0, level3Passwords.Length)];
                break;
            default:
                Debug.LogError("Feil valg");
                break;
        }
        Terminal.WriteLine("Du har valgt level " + level);
        Terminal.WriteLine("Skriv passordet");
    }
    private void CheckPassword(string input)
    {
        {
            if (input == password)
            {
                DisplayWinScreen();
            }
            else
            {
                Terminal.WriteLine("Feil");
                lives--;
                if (lives < 1)
                {
                    Terminal.WriteLine("Du døde");
                }
            }
        }
    }
    void DisplayWinScreen()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward();

    }

    private void ShowLevelReward()
    {
        Terminal.WriteLine("VERI GOD SOLJA");
    }
}
