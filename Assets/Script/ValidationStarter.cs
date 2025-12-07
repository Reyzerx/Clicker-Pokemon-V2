using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text;
using System;

public class ValidationStarter : MonoBehaviour
{
    public Core core;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void validerStarter(Pokemon pokemonIn) 
    {
        core.setSelectedPokemon(pokemonIn);
        core.GetComponent<CoreRefreshUI>().afficherSceneJeu(true);
    }

    public void afficherStats()
    {
        StringBuilder text = new StringBuilder();

        // sprite.sprite = SaveData.dataStatic.starter.sprite;

        text.Append("nom = " + SaveData.dataStatic.starter.nom);
        text.Append(" / niveau = " + SaveData.dataStatic.starter.niveau);
        text.Append(" / degat = " + SaveData.dataStatic.starter.degat);
        text.Append(" / exp = " + SaveData.dataStatic.starter.expActuel);
        text.Append(" / type1 = " + SaveData.dataStatic.starter.getType1());    
        text.Append(" / type2 = " + SaveData.dataStatic.starter.getType2()); 
        text.Append(" / estStocker = " + SaveData.dataStatic.starter.estStocker);
        text.Append(" / estEquipe = " + SaveData.dataStatic.starter.estEquipe);
        text.Append(" / estShop = " + SaveData.dataStatic.starter.estShop);
        text.Append(" / estSauvage = " + SaveData.dataStatic.starter.estSauvage);

        Debug.Log(text.ToString());
    }
}
