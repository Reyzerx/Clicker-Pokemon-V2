using UnityEngine;

public enum Rarete
{
    Commun,
    Rare,
    Epique,
    Legendaire
}

[CreateAssetMenu(fileName = "NouveauPokemon", menuName = "Pokemon/Template")]
public class PokemonTemplate : ScriptableObject
{

    [Header("Identité")]
    public string nom;
    public Sprite sprite;

    [Header("Types")]
    public Pokemon.listTypeName type1 = Pokemon.listTypeName.aucun;
    public Pokemon.listTypeName type2 = Pokemon.listTypeName.aucun;

    [Header("Stats de base (niveau 1)")]
    public int baseDegat = 1;
    public int basePv = 45;

    [Header("Croissance par niveau")]
    public float multiplicateurDegat = 1.1f;
    public float multiplicateurPv = 1.2f;
    public float multiplicateurExpParNiveau = 1.15f; // croissance exponentielle

    [Header("Expérience")]
    public int baseExpPourUpNiveau = 10;
    public int baseExpDonnee = 20;
    public float expGrowth = 1.15f; // croissance par niveau

    [Header("Shop")]
    public int cost;

    [Header("Statuts par défaut")]
    public bool estStocker;
    public bool estEquipe;
    public bool estShop;
    public bool estSauvage;

    [Header("Rareté")]
    public Rarete rarete = Rarete.Commun;

    public string ToDebugString()
    {
        return
            $"[TEMPLATE]\n" +
            $"- Nom: {nom}\n" +
            $"- Types: {type1}/{type2}\n" +
            $"- Base PV: {basePv}\n" +
            $"- Base Dégâts: {baseDegat}\n" +
            $"- Mult PV: x{multiplicateurPv}\n" +
            $"- Mult Dégâts: x{multiplicateurDegat}\n" +
            $"- Base Exp Up: {baseExpPourUpNiveau}\n" +
            $"- Cost: {cost}\n" +
            $"- Flags: Stocker={estStocker}, Équipe={estEquipe}, Shop={estShop}, Sauvage={estSauvage}";
    }
}
