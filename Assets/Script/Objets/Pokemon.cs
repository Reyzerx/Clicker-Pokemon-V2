using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Internal;
using Unity.VisualScripting;
using UnityEngine;

//[System.Serializable]
public class Pokemon
{
    public enum listTypeName
    {
        acier, aucun, combat, dragon, eau,
        electrik, feu, glace, insecte, normal,
        plante, poison, psy, roche, sol, spectre,
        tenebre, vol
    };

    public Rarete rarete;

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
    public int pokedollarsGagnes;
    public int expDonnee;

    [Space]
    [Header("Shop")]
    public int cost;


    [Space]
    [Header("Shop")]
    public float tauxApparition;


    // ************
    // Constructeur
    //*************

    public Pokemon()
    {

    }

    public Pokemon(PokemonTemplate template, int niveau, bool estEnnemi)
    {
        // --- Identité ---
        nom = template.nom;
        sprite = template.sprite;
        type1 = template.type1;
        type2 = template.type2;
        rarete = template.rarete; // ajout de la rareté
        this.niveau = niveau;

        // --- STATS DYNAMIQUES ---
        maxPv = Mathf.RoundToInt(template.basePv * Mathf.Pow(template.multiplicateurPv, niveau - 1));
        currentPv = maxPv;

        degat = Mathf.RoundToInt(template.baseDegat * Mathf.Pow(template.multiplicateurDegat, niveau - 1));

        // --- EXPÉRIENCE ---
        expActuel = 0;
        expPourUpNiveau = template.baseExpPourUpNiveau * niveau;

        // XP donnée si vaincu (formule dynamique)
        float bonusRarete = rarete switch
        {
            Rarete.Rare => 1.3f,
            Rarete.Epique => 1.6f,
            Rarete.Legendaire => 2.0f,
            _ => 1f
        };

        expDonnee = Mathf.RoundToInt(template.baseExpDonnee * Mathf.Pow(template.multiplicateurExpParNiveau, niveau - 1) * bonusRarete);

        // --- POKEDOLLARS ---
        if (estEnnemi)
            pokedollarsGagnes = Mathf.RoundToInt(template.cost * niveau * 0.5f);
        else
            pokedollarsGagnes = 0;

        // --- STATUTS ---
        estStocker = template.estStocker;
        estEquipe = template.estEquipe;
        estShop = template.estShop;
        estSauvage = template.estSauvage;

        // Override si c’est un ennemi
        if (estEnnemi)
        {
            estSauvage = true;
            estShop = false;
            estEquipe = false;
            estStocker = false;
        }
    }


    public void init()
    {
        currentPv = maxPv;
    }


    public string ToDebugString()
    {
        return
            $"[POKEMON INSTANCE]\n" +
            $"- Nom: {nom}\n" +
            $"- Niveau: {niveau}\n" +
            $"- PV: {currentPv}/{maxPv}\n" +
            $"- Dégâts: {degat}\n" +
            $"- Types: {type1}/{type2}\n" +
            $"- Exp: {expActuel}/{expPourUpNiveau}\n" +
            $"- Cost: {cost}\n" +
            $"- Flags: Stocker={estStocker}, Équipe={estEquipe}, Shop={estShop}, Sauvage={estSauvage}";
    }

    public void takeDamage(int damage)
    {
        currentPv = Mathf.Max(currentPv - damage, 0);
    }

    private int CalculExpPourNiveau(int niveau)
    {
        // Formule simple : 20 + niveau * 10
        return 20 + (niveau * 10);
    }

    public bool AjouterExperience(int amount)
    {
        expActuel += amount;

        bool leveledUp = false;

        while (expActuel >= expPourUpNiveau)
        {
            expActuel -= expPourUpNiveau;
            niveau++;
            leveledUp = true;

            // Recalcul des stats
            RecalculerStats();

            // Nouveau seuil d'XP
            expPourUpNiveau = CalculExpPourNiveau(niveau);
        }

        return leveledUp;
    }

    private void RecalculerStats()
    {
        // Exemple simple : progression linéaire
        maxPv = currentPv + (niveau * 5);
        currentPv = maxPv; // on restaure les PV au level up
        degat = degat + (niveau * 2);
    }



    // *************
    // Getter/Setter
    //**************

    public string getType1()
    {
        return type1.ToString();
    }

    public string getType2()
    {
        return type2.ToString();
    }

    public string getNom()
    {
        return nom;
    }
    public void setNom(string newValue)
    {
        if (!StringUtility.IsNullOrWhiteSpace(newValue))
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
