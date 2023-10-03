using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Starter_gestion_ui : MonoBehaviour
{
    //fond pour pour effet click sur pokéball
    public Image fondTransparent;

    //les images pokémon a afficher quand on click sur pokéball
    public Image carapuce;
    public Image bulbizarre;
    public Image salameche;

    //Les animation de pokéball qui bouge quand on clique dessus
    public Animator pokeballCarapuceAnimation;
    public Animator pokeballBulbizarreAnimation;
    public Animator pokeballSalamecheAnimation;

    public Animator spriteCarapuceAnimation;
    public Animator spriteBulbizarreAnimation;
    public Animator spriteSalamecheAnimation;

    //La zone de texte pour le choix starter + le canva + l'anim + bouton oui + bouton non
    public TextMeshProUGUI zoneTexteChoixStarter;
    public GameObject canvasChoixStarter;
    public Animator canvasApparitionChoixStarter;
    public Button boutonOui;
    public Button boutonNon;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void ClickForFondTransparent()
    {
        if (spriteCarapuceAnimation.GetBool("moveSprite") || spriteBulbizarreAnimation.GetBool("moveSprite") || spriteSalamecheAnimation.GetBool("moveSprite"))
        {
            fondTransparent.color = new Color(0, 0, 0, 0.95f);
        }
        else
        {
            fondTransparent.color = new Color(0, 0, 0, 0);
        }
    }

    public void ClickForCarapuce()
    {
        //Carapuce
        pokeballCarapuceAnimation.SetBool("movePokeball", !pokeballCarapuceAnimation.GetBool("movePokeball"));
        spriteCarapuceAnimation.SetBool("moveSprite", !spriteCarapuceAnimation.GetBool("moveSprite"));
        //Bulbizarre
        pokeballBulbizarreAnimation.SetBool("movePokeball", false);
        spriteBulbizarreAnimation.SetBool("moveSprite", false);
        //Salameche
        pokeballSalamecheAnimation.SetBool("movePokeball", false);
        spriteSalamecheAnimation.SetBool("moveSprite", false);
    }

    public void ClickForBulbizarre()
    {
        //Carapuce
        pokeballCarapuceAnimation.SetBool("movePokeball", false);
        spriteCarapuceAnimation.SetBool("moveSprite", false);
        //Bulbizarre
        pokeballBulbizarreAnimation.SetBool("movePokeball", !pokeballBulbizarreAnimation.GetBool("movePokeball"));
        spriteBulbizarreAnimation.SetBool("moveSprite", !spriteBulbizarreAnimation.GetBool("moveSprite"));
        //Salameche
        pokeballSalamecheAnimation.SetBool("movePokeball", false);
        spriteSalamecheAnimation.SetBool("moveSprite", false);
    }

    public void ClickForSalameche()
    {
        //Carapuce
        pokeballCarapuceAnimation.SetBool("movePokeball", false);
        spriteCarapuceAnimation.SetBool("moveSprite", false);
        //Bulbizarre
        pokeballBulbizarreAnimation.SetBool("movePokeball", false);
        spriteBulbizarreAnimation.SetBool("moveSprite", false);
        //Salameche
        pokeballSalamecheAnimation.SetBool("movePokeball", !pokeballSalamecheAnimation.GetBool("movePokeball"));
        spriteSalamecheAnimation.SetBool("moveSprite", !spriteSalamecheAnimation.GetBool("moveSprite"));
    }


    //*************************
    //*** SELECTION STARTER ***
    //*************************

    public void SelectCarapuceAsStarter()
    {
        zoneTexteChoixStarter.text = "Choisir Carapuce le pokémon Eau ?";
        canvasApparitionChoixStarter.SetBool("apparitionCanvas", true);

        boutonOui.onClick.RemoveAllListeners();
        boutonNon.onClick.RemoveAllListeners();

        //mettre le listener gameobject starter = "carapuce" dans le script save + masquer tout le canva starter
        //mettre le listener fermer canva
        //boutonOui.onClick.AddListener();
        boutonNon.onClick.AddListener(() => ListenerForCarapuceBoutonNon());
    }
    public void ListenerForCarapuceBoutonNon()
    {
        canvasApparitionChoixStarter.SetBool("apparitionCanvas", false);
        ClickForCarapuce();
    }

    public void SelectBulbizarreAsStarter()
    {
        zoneTexteChoixStarter.text = "Choisir Bulbizarre le pokémon Plante ?";
        canvasApparitionChoixStarter.SetBool("apparitionCanvas", true);

        boutonOui.onClick.RemoveAllListeners();
        boutonNon.onClick.RemoveAllListeners();

        //mettre le listener gameobject starter = "carapuce" dans le script save + masquer tout le canva starter
        //mettre le listener fermer canva
        //boutonOui.onClick.AddListener();
        boutonNon.onClick.AddListener(() => ListenerForBlbizarreBoutonNon());
    }
    public void ListenerForBlbizarreBoutonNon()
    {
        canvasApparitionChoixStarter.SetBool("apparitionCanvas", false);
        ClickForBulbizarre();
    }

    public void SelectSalamecheAsStarter()
    {
        zoneTexteChoixStarter.text = "Choisir Salameche le pokémon Feu ?";
        canvasApparitionChoixStarter.SetBool("apparitionCanvas", true);

        boutonOui.onClick.RemoveAllListeners();
        boutonNon.onClick.RemoveAllListeners();

        //mettre le listener gameobject starter = "carapuce" dans le script save + masquer tout le canva starter
        //mettre le listener fermer canva
        //boutonOui.onClick.AddListener();
        boutonNon.onClick.AddListener(() => ListenerForSalamecheBoutonNon());
    }
    public void ListenerForSalamecheBoutonNon()
    {
        canvasApparitionChoixStarter.SetBool("apparitionCanvas", false);
        ClickForSalameche();
    }
}
