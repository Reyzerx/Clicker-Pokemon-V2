using UnityEngine;

[System.Serializable]
public class PokemonEncounterData
{
    public PokemonTemplate template; // référence au template du Pokémon
    [Range(0f, 100f)] public float tauxApparition;
    public int niveauMin;
    public int niveauMax;
    public Rarete rarete;
}
