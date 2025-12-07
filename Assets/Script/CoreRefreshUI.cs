using UnityEngine;
using TMPro;
using System.Text;
using UnityEngine.UI;

public class CoreRefreshUI : MonoBehaviour
{
    public GameObject sceneStarter;
    public GameObject sceneJeu;

    public GameObject UIForSelectedPokemon;
    public Image spriteSelectedPokemon;
    public TextMeshProUGUI texteSelectedPokemon;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sceneJeu.SetActive(false);
        sceneStarter.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void afficherSceneJeu(bool afficherSceneIn)
    {
        sceneJeu.SetActive(afficherSceneIn);
    }

    public void afficherSceneStarter(bool afficherSceneIn)
    {
        sceneStarter.SetActive(afficherSceneIn);
    }

    public void refreshUISelectedPokemon(Pokemon pokemonIn)
    {
       spriteSelectedPokemon.sprite = pokemonIn.sprite;

       StringBuilder text = new StringBuilder();

        text.Append("nom = " + pokemonIn.getNom());
        text.Append(" / niveau = " + pokemonIn.getNiveau());
        text.Append("\ndegat = " + pokemonIn.getDegat());
        text.Append(" / exp = " + pokemonIn.getExpActuel());
        text.Append("\ntype1 = " + pokemonIn.getType1());    
        text.Append(" / type2 = " + pokemonIn.getType2()); 
        text.Append("\nestStocker = " + pokemonIn.estStocker);
        text.Append(" / estEquipe = " + pokemonIn.estEquipe);
        text.Append("\nestShop = " + pokemonIn.estShop);
        text.Append(" / estSauvage = " + pokemonIn.estSauvage);
        text.Append("\ncurrentPv = " + pokemonIn.getCurrentPv());
        text.Append(" / maxPv = " + pokemonIn.getMaxPv());
        text.Append("\ncost = " + pokemonIn.getCost());

       texteSelectedPokemon.text = text.ToString();
    }
}
