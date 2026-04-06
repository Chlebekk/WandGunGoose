using Assets.Scripts.Objects;
using System;
using System.Collections.Generic;
using UnityEngine;

public class StaticData : MonoBehaviour
{
    private static ProgramData programData;
    private static GameData gameData;
    private static PlayerData playerData;
    public static void LoadGameData()
    {
        if (/*TODO: check if a save file exists if yes then load it to Data objects*/1 == 2)
        {
            Debug.Log("Save file found, loading data...");
            //TODO: Load save file data to Data objects
        }
        else
        {
            Debug.Log("No save file found, initializing new data...");
            Initialize();
        }
    }
    public static void SaveGameData()
    {

    }
    private static void Initialize()
    {

        programData = new ProgramData();
        gameData = new GameData();
        playerData = new PlayerData();
        DebugLog();
    } 
    public static void DebugLog()
    {
        
        Debug.Log("Program Data:");
        Debug.Log(JsonUtility.ToJson(programData));
        foreach (Keybind keybind in programData.GetKeybinds)
        {
            Debug.Log(JsonUtility.ToJson(keybind));
        }
        Debug.Log("Game Data:");
        Debug.Log(JsonUtility.ToJson(gameData));
        Debug.Log("Player Data:");
        Debug.Log(JsonUtility.ToJson(playerData));
    }
    
}
