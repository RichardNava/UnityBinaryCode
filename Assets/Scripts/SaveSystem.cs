using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SavePlayer(PlayerController playerController)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string filePath = Application.persistentDataPath + "/player.fun";
        FileStream stream = new FileStream(filePath, FileMode.Create);
        Debug.Log(filePath);
        Player data = new Player(playerController);
        formatter.Serialize(stream, data);
        stream.Close();
    }
    public static Player LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.fun";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            Player data = formatter.Deserialize(stream) as Player;
            stream.Close();

            return data;
        }
        else
        {
            Debug.Log("No existe ningun archivo en la ruta especificada\n" + path);
        }
        return null;
    } 


}
