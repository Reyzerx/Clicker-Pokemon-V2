using UnityEngine;

public class WODPlayer : MonoBehaviour
{
    public MPlayer ui;      // ton module UI
    public Player player;    // ta logique métier

    // Dossier où sont stockées les icônes de type
    private const string typeSpritePath = "Sprites/types_fr_"; // base du nom

    public void Bind(Player p)
    {
        player = p;
        RefreshUI();
    }

    public void RefreshUI()
    {
        if (player == null || player.pokemon == null) return;

        var p = player.pokemon;

        // --- Nom + Niveau ---
        ui.nameAndLevelText.text = $"{p.nom}  Niv {p.niveau}";

        // --- Sprite principal ---
        ui.spriteImage.sprite = p.sprite;

        // --- Types ---
        // Type 1
        ui.typeImage1.sprite = ui.typeSprites[p.type1];
        ui.typeImage1.gameObject.SetActive(p.type1 != Pokemon.listTypeName.aucun);

        // Type 2
        ui.typeImage2.sprite = ui.typeSprites[p.type2];
        ui.typeImage2.gameObject.SetActive(p.type2 != Pokemon.listTypeName.aucun);

        // --- XP ---
        ui.xpSlider.maxValue = p.expPourUpNiveau;
        ui.xpSlider.value = p.expActuel;
    }
}
