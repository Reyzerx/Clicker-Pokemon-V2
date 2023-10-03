using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
}
