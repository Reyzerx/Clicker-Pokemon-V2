using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Pokemon
{
    //Pokémon allié
    public int niveau;
    public int exp;
    public int expPourUpNiveau;
    public int degat;
    
    public string nom;
    public string[] type;

    public Sprite sprite;

    public bool estStocker;
    public bool estEquipe;
    public bool estShop;
    public bool estSauvage;


    //pokemon Ennemi
    public int currentPv;
    public int maxPv;
}
