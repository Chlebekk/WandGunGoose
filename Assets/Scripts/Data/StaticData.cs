using Assets.Scripts.Objects;
using System.Collections.Generic;
using UnityEngine;

public class StaticData : MonoBehaviour
{
    //programData
    private static float gameVolume;
    private static float sfxVolume;
    private static float musicVolume;
    private static List<Keybind> keybinds;
    //saveFileData
    private static bool isCheated;
    private static bool isDevMode;
    private static bool isFirstRun;
    private static int runCount;
    private static int deathCount;
    private static int winCount;
    private static int resetCount;
    private static int playerLevel;
    private static int playerXp;
    private static int playerHealth;
    private static int playerMaxHealth;
    private static int playerMp;
    private static int playerMaxMp;
    private static int playerGold;
    public void Start()
    {
        LoadGameData();
    }
    public static void LoadGameData()
    {
        Initialize();
    }
    public static void SaveGameData()
    {

    }
    private static void Initialize()
    {
        isCheated = false;
        isDevMode = false;
        isFirstRun = true;
        gameVolume = 1.0f;
        sfxVolume = 1.0f;
        musicVolume = 1.0f;
        keybinds = new List<Keybind>();
        InitialKeybinds();
    }
    private static void InitialKeybinds()
    {
        keybinds.Add(new Keybind("Move Up", new List<string> { "W"}));
        keybinds.Add(new Keybind("Move Down", new List<string> { "S"}));
        keybinds.Add(new Keybind("Move Left", new List<string> { "A"}));
        keybinds.Add(new Keybind("Move Right", new List<string> { "D"}));
        keybinds.Add(new Keybind("Use Active Item", new List<string> { "Space" }));
        keybinds.Add(new Keybind("Interact", new List<string> { "Mouse1" }));
        keybinds.Add(new Keybind("Inspect", new List<string> { "Mouse2" }));
        keybinds.Add(new Keybind("Pause", new List<string> { "Escape" }));
        keybinds.Add(new Keybind("Open Inventory", new List<string> { "I" }));
        keybinds.Add(new Keybind("Restart Run", new List<string> { "R" }));
    }
}
