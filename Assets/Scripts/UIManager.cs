using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI level;
    public TextMeshProUGUI health;
    public PlayerController player;


    void Start()
    {
        level.text = player.level.ToString();
        health.text = player.health.ToString();
    }

    void Update()
    {
        level.text = player.level.ToString();
        health.text = player.health.ToString();
    }
}
