using UnityEngine;

public class Enemy
{
    public Pokemon pokemon;   // L’ennemi utilise un Pokémon
    public bool isAlive => pokemon.currentPv > 0;

    public Enemy(Pokemon pokemon)
    {
        this.pokemon = pokemon;
    }
}
