using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [Header("Main")]
    [Space(10)]
    [SerializeField] int Coin;
    [SerializeField] int Healt;
    [SerializeField] int Stamina;

    [Header("Level And XP")]
    [Space(10)]
    public int level;
    public static int statspoint = 20;
    public int xp;
    void Update()
    {
        Healt = 100 + Stats.maxhp * 10;
        Stamina = 100 + Stats.maxstam * 10;
    }
}