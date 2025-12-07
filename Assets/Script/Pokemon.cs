using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Internal;
using Unity.VisualScripting;
using UnityEngine;

[System.Serializable]
public class Pokemon
{
    public enum listTypeName
    {
        acier, aucun, combat, dragon, eau,
        electrik, feu, glace, insecte, normal,
        plante, poison, psy, roche, sol, spectre,
        tenebre, vol
    };

    //Pokémon allié
    [Space]
    [Header("Player")]
    public string nom;
    public int niveau;
    public int degat;
    public Sprite sprite;
    
    public listTypeName type1 = listTypeName.aucun;
    public listTypeName type2 = listTypeName.aucun;
    
    public int expActuel;
    public int expPourUpNiveau;

    public bool estStocker;
    public bool estEquipe;
    public bool estShop;
    public bool estSauvage;


    //pokemon Ennemi
    [Space]
    [Header("Enemy")]
    public int currentPv;
    public int maxPv;

    [Space]
    [Header("Shop")]
    public int cost;


    public string getType1(){
        return type1.ToString();
    }
    
    public string getType2(){
        return type2.ToString();
    }

    public string getNom()
    {
        return nom;
    }
    public void setNom(string newValue)
    {
        if(! StringUtility.IsNullOrWhiteSpace(newValue))
        {
            nom = newValue;
        }
    }

    public int getNiveau()
    {
        return niveau;
    }
    public void setNiveau(int newValue)
    {
        niveau = newValue;
    }

    public int getDegat()
    {
        return degat;
    }
    public void setDegat(int newValue)
    {
        degat = newValue;
    }

    public int getExpActuel()
    {
        return expActuel;
    }
    public void setExpActuel(int newValue)
    {
        expActuel = newValue;
    }

    public int getExpPourUpNiveau()
    {
        return expPourUpNiveau;
    }
    public void setExpPourUpNiveau(int newValue)
    {
        expPourUpNiveau = newValue;
    }

    public int getCurrentPv()
    {
        return currentPv;
    }
    public void setCurrentPv(int newValue)
    {
        currentPv = newValue;
    }

    public int getMaxPv()
    {
        return maxPv;
    }
    public void setMaxPv(int newValue)
    {
        maxPv = newValue;
    }

    public int getCost()
    {
        return cost;
    }
    public void setCost(int newValue)
    {
        cost = newValue;
    }
}
