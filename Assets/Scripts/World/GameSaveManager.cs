//FILE          :   GameSaveManager.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   12/12/2019
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

//NAME : GameSaveManager
//PURPOSE : manages the saves for the game
public class GameSaveManager
{
    private static string currentSaveSlot;

    public static void SetCurrentSlot(string slotName)
    {
        currentSaveSlot = slotName;
    }

    public static void SaveGame()
    {
        GameSave gameSave = CreateGameSaveObject();
        FileStream stream = File.Create(Application.persistentDataPath + "/" + currentSaveSlot + ".gameSave");
        BinaryFormatter formatter = new BinaryFormatter();
        formatter.Serialize(stream, gameSave);
        stream.Close();
    }

    public static void LoadGame()
    {
        if (File.Exists(Application.persistentDataPath + "/" + currentSaveSlot + ".gameSave"));
        {
            FileStream stream = File.Open(Application.persistentDataPath + "/" + currentSaveSlot + ".gameSave", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            GameSave gameSave = new GameSave();
            gameSave = (GameSave)formatter.Deserialize(stream);
            stream.Close();
        }
    }

    private static GameSave CreateGameSaveObject()
    {
        GameSave save = new GameSave();
        //set save information here

        return save;
    }
}
