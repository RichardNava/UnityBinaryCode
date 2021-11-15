using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Player
{
    public int level;
    public int health;

    public Player(PlayerController player)
    {
        this.level = player.level;
        this.health = player.health;
    }
}
