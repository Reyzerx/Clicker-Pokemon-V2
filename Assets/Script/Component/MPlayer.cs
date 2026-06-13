using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MPlayer : MonoBehaviour
{
     [Header("Identité du Pokémon")]
    public Image spriteImage;
    public TextMeshProUGUI nameAndLevelText;

    [Header("Types")]
    public Image typeImage1;
    public Image typeImage2;

    [Header("Experience")]
    public Slider xpSlider;

    [HideInInspector]
    public Dictionary<Pokemon.listTypeName, Sprite> typeSprites;

    void Awake()
    {
        // Chargement de tous les sous-sprites de la spritesheet "types_fr"
        typeSprites = new Dictionary<Pokemon.listTypeName, Sprite>();

        Sprite[] sprites = Resources.LoadAll<Sprite>("types_fr");

        foreach (var s in sprites)
        {
            switch (s.name.ToLower())
            {
                case "types_fr_0": typeSprites[Pokemon.listTypeName.aucun] = s; break;
                case "types_fr_1": typeSprites[Pokemon.listTypeName.insecte] = s; break;
                case "types_fr_2": typeSprites[Pokemon.listTypeName.tenebre] = s; break;
                case "types_fr_3": typeSprites[Pokemon.listTypeName.dragon] = s; break;
                case "types_fr_4": typeSprites[Pokemon.listTypeName.electrik] = s; break;
                //case "types_fr_5": typeSprites[Pokemon.listTypeName.fee] = s; break;
                case "types_fr_6": typeSprites[Pokemon.listTypeName.combat] = s; break;
                case "types_fr_7": typeSprites[Pokemon.listTypeName.feu] = s; break;
                case "types_fr_8": typeSprites[Pokemon.listTypeName.vol] = s; break;
                case "types_fr_9": typeSprites[Pokemon.listTypeName.spectre] = s; break;
                case "types_fr_10": typeSprites[Pokemon.listTypeName.plante] = s; break;
                case "types_fr_11": typeSprites[Pokemon.listTypeName.sol] = s; break;
                case "types_fr_12": typeSprites[Pokemon.listTypeName.glace] = s; break;
                case "types_fr_13": typeSprites[Pokemon.listTypeName.normal] = s; break;
                case "types_fr_14": typeSprites[Pokemon.listTypeName.poison] = s; break;
                case "types_fr_15": typeSprites[Pokemon.listTypeName.psy] = s; break;
                case "types_fr_16": typeSprites[Pokemon.listTypeName.roche] = s; break;
                case "types_fr_17": typeSprites[Pokemon.listTypeName.acier] = s; break;
                case "types_fr_18": typeSprites[Pokemon.listTypeName.eau] = s; break;
                //case "types_fr_19": typeSprites[Pokemon.listTypeName.stellaire] = s; break;
            }
        }

        Debug.Log($"✅ {typeSprites.Count} sprites de type chargés depuis 'types_fr'");
    }
}
