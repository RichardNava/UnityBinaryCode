using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int level;
    public int health;

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }
    public void LoadPlayer()
    {
        Player data = SaveSystem.LoadPlayer();
        if (data != null)
        {
            level = data.level;
            health = data.health;
        }
    }
    
    public void SumLevel()
    {
        level++;
    }
    public void SubLevel()
    {
        level--;

    }
    public void SumHealth()
    {
        health++;
    }
    public void SubHealth()
    {
        health--;

    }
}

