using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NouvelleRoute", menuName = "Pokemon/Route")]
public class RoutesTemplate : ScriptableObject
{
    public string nom;
    public AudioClip musique;
    public bool estDebloquee = false;

    public List<PokemonEncounterData> pokemonRencontrables;


    public string ToDebugString()
    {
        string s = $"[ROUTE]\n";
        s += $"- Nom: {nom}\n";
        s += $"- Débloquée: {estDebloquee}\n";
        s += $"- Musique: {(musique != null ? musique.name : "null")}\n";
        s += $"- Pokémon rencontrables:\n";

        if (pokemonRencontrables == null || pokemonRencontrables.Count == 0)
        {
            s += "  (Aucun)\n";
            return s;
        }

        foreach (var p in pokemonRencontrables)
        {
            s += $"  • {p.template.nom} | taux={p.tauxApparition} | niv {p.niveauMin}-{p.niveauMax}\n";
        }

        return s;
    }

    public Pokemon TirerPokemon()
    {
        // 1. Calcul du total des probabilités
        float total = 0f;
        foreach (var e in pokemonRencontrables)
            total += e.tauxApparition;

        if (total <= 0f)
        {
            Debug.LogWarning("⚠ Aucun taux d'apparition valide dans la route !");
            return null;
        }

        // 2. Tirage aléatoire entre 0 et total
        float r = Random.Range(0f, total);
        float cumul = 0f;

        // 3. Sélection du Pokémon
        foreach (var e in pokemonRencontrables)
        {
            cumul += e.tauxApparition;
            if (r <= cumul)
            {
                int niveau = Random.Range(e.niveauMin, e.niveauMax + 1);
                return new Pokemon(e.template, niveau, true);
            }
        }

        // Sécurité (ne devrait jamais arriver)
        return null;
    }

}
