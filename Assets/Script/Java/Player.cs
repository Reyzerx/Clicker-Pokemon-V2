using UnityEngine;

public class Player
{
    public Pokemon pokemon;
    public bool isAlive => pokemon.currentPv > 0;

    public Player(Pokemon pokemon)
    {
        this.pokemon = pokemon;
    }
}
