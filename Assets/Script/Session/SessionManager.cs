using System;
using System.Collections.Generic;
using UnityEngine;


public class SessionManager : MonoBehaviour
{
    public static SessionManager Instance;

    public Player selectedPlayerPokemon = null;
    public Enemy selectedEnemyPokemon = null;

    public RoutesTemplate selectedRoute;

    public List<RoutesTemplate> listeDeRoutes;

    [Space]
    [Header("Player")]
    public List<Pokemon> listePlayerEquipePokemon = new List<Pokemon>();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // persiste entre les scènes
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void InitPlayer(Pokemon pokemonIn)
    {
        selectedPlayerPokemon = new Player(pokemonIn);
    }

    public void addToPlayerEquipePokemon(Pokemon pokemonIn)
    {
        listePlayerEquipePokemon.Add(pokemonIn);
    }

    public void InitEnemyFromRoute()
    {
        if (selectedRoute == null)
        {
            Debug.Log("Aucune route sélectionnée → pas d’ennemi");
            return;
        }

        Pokemon _pokemon = selectedRoute.TirerPokemon();
        selectedEnemyPokemon = new Enemy(_pokemon);
    }

    public void RespawnEnemyFromRoute()
    {
        if (selectedRoute == null)
        {
            Debug.Log("Aucune route sélectionnée → pas d’ennemi à respawn");
            return;
        }

        Pokemon _pokemon = selectedRoute.TirerPokemon();
        selectedEnemyPokemon = new Enemy(_pokemon);

        Debug.Log($"Nouvel ennemi apparu : {_pokemon.nom}");
    }

}
