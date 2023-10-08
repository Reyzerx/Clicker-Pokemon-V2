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
    public Image carapuceImage;
    public Image bulbizarreImage;
    public Image salamecheImage;

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

    //Les 3 objets pokemon a setup pour sauvegarder le choix
    public Pokemon carapuce = new Pokemon();
    public Pokemon bulbizarre = new Pokemon();
    public Pokemon salameche = new Pokemon();

    //Suppr
    public ValidationStarter test;
    public GameObject canvasValidateStarter;


    // Start is called before the first frame update
    void Start()
    {
        carapuceImage.GetComponent<Button>().interactable = false;
        bulbizarreImage.GetComponent<Button>().interactable = false;
        salamecheImage.GetComponent<Button>().interactable = false;

        //Suppr
        canvasValidateStarter.SetActive(false);
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
        carapuceImage.GetComponent<Button>().interactable = !carapuceImage.GetComponent<Button>().interactable;
        pokeballCarapuceAnimation.SetBool("movePokeball", !pokeballCarapuceAnimation.GetBool("movePokeball"));
        spriteCarapuceAnimation.SetBool("moveSprite", !spriteCarapuceAnimation.GetBool("moveSprite"));
        //Bulbizarre
        bulbizarreImage.GetComponent<Button>().interactable = false;
        pokeballBulbizarreAnimation.SetBool("movePokeball", false);
        spriteBulbizarreAnimation.SetBool("moveSprite", false);
        //Salameche
        salamecheImage.GetComponent<Button>().interactable = false;
        pokeballSalamecheAnimation.SetBool("movePokeball", false);
        spriteSalamecheAnimation.SetBool("moveSprite", false);

        canvasApparitionChoixStarter.SetBool("apparitionCanvas", false);
    }

    public void ClickForBulbizarre()
    {
        //Carapuce
        carapuceImage.GetComponent<Button>().interactable = false;
        pokeballCarapuceAnimation.SetBool("movePokeball", false);
        spriteCarapuceAnimation.SetBool("moveSprite", false);
        //Bulbizarre
        bulbizarreImage.GetComponent<Button>().interactable = !bulbizarreImage.GetComponent<Button>().interactable;
        pokeballBulbizarreAnimation.SetBool("movePokeball", !pokeballBulbizarreAnimation.GetBool("movePokeball"));
        spriteBulbizarreAnimation.SetBool("moveSprite", !spriteBulbizarreAnimation.GetBool("moveSprite"));
        //Salameche
        salamecheImage.GetComponent<Button>().interactable = false;
        pokeballSalamecheAnimation.SetBool("movePokeball", false);
        spriteSalamecheAnimation.SetBool("moveSprite", false);

        canvasApparitionChoixStarter.SetBool("apparitionCanvas", false);
    }

    public void ClickForSalameche()
    {
        //Carapuce
        carapuceImage.GetComponent<Button>().interactable = false;
        pokeballCarapuceAnimation.SetBool("movePokeball", false);
        spriteCarapuceAnimation.SetBool("moveSprite", false);
        //Bulbizarre
        bulbizarreImage.GetComponent<Button>().interactable = false;
        pokeballBulbizarreAnimation.SetBool("movePokeball", false);
        spriteBulbizarreAnimation.SetBool("moveSprite", false);
        //Salameche
        salamecheImage.GetComponent<Button>().interactable = !salamecheImage.GetComponent<Button>().interactable;
        pokeballSalamecheAnimation.SetBool("movePokeball", !pokeballSalamecheAnimation.GetBool("movePokeball"));
        spriteSalamecheAnimation.SetBool("moveSprite", !spriteSalamecheAnimation.GetBool("moveSprite"));

        canvasApparitionChoixStarter.SetBool("apparitionCanvas", false);
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
        boutonOui.onClick.AddListener(() => ListenerForCarapuceBoutonOui());
        boutonNon.onClick.AddListener(() => ListenerForCarapuceBoutonNon());
    }
    public void ListenerForCarapuceBoutonOui()
    {
        SaveData.dataStatic.starter = carapuce;
        //Suppr
        canvasValidateStarter.SetActive(true);
        test.afficherStats();
    }
    public void ListenerForCarapuceBoutonNon()
    {
        canvasApparitionChoixStarter.SetBool("apparitionCanvas", false);
        ClickForCarapuce();
        ClickForFondTransparent();
    }


    //*************************
    //****** BULBIZARRE *******
    //*************************

    public void SelectBulbizarreAsStarter()
    {
        zoneTexteChoixStarter.text = "Choisir Bulbizarre le pokémon Plante ?";
        canvasApparitionChoixStarter.SetBool("apparitionCanvas", true);

        boutonOui.onClick.RemoveAllListeners();
        boutonNon.onClick.RemoveAllListeners();

        boutonOui.onClick.AddListener(() => ListenerForBulbizarreBoutonOui());
        boutonNon.onClick.AddListener(() => ListenerForBlbizarreBoutonNon());
    }
    public void ListenerForBulbizarreBoutonOui()
    {
        SaveData.dataStatic.starter = bulbizarre;
        //Suppr
        canvasValidateStarter.SetActive(true);
        test.afficherStats();
    }
    public void ListenerForBlbizarreBoutonNon()
    {
        canvasApparitionChoixStarter.SetBool("apparitionCanvas", false);
        ClickForBulbizarre();
        ClickForFondTransparent();
    }


    //*************************
    //****** SALAMECHE ********
    //*************************

    public void SelectSalamecheAsStarter()
    {
        zoneTexteChoixStarter.text = "Choisir Salameche le pokémon Feu ?";
        canvasApparitionChoixStarter.SetBool("apparitionCanvas", true);

        boutonOui.onClick.RemoveAllListeners();
        boutonNon.onClick.RemoveAllListeners();

        boutonOui.onClick.AddListener(() => ListenerForSalamecheBoutonOui());
        boutonNon.onClick.AddListener(() => ListenerForSalamecheBoutonNon());
    }
    public void ListenerForSalamecheBoutonOui()
    {
        SaveData.dataStatic.starter = salameche;
        //Suppr
        canvasValidateStarter.SetActive(true);
        test.afficherStats();
    }
    public void ListenerForSalamecheBoutonNon()
    {
        canvasApparitionChoixStarter.SetBool("apparitionCanvas", false);
        ClickForSalameche();
        ClickForFondTransparent();
    }
}