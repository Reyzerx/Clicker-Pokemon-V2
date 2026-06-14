using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GlobalClicHandler : MonoBehaviour
{
    public LayerMask clickableLayer; // ton layer estCliquable
    public GraphicRaycaster raycaster;
    public EventSystem eventSystem;

    public WODEnemy WodEnemy;
    public WODPlayer WodPlayer;

    void Update()
    {
        // Souris ou doigt
        if (Input.GetMouseButtonDown(0) || Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if (IsClickOnClickableArea())
            {
                Player player = SessionManager.Instance.selectedPlayerPokemon;
                Enemy enemy = SessionManager.Instance.selectedEnemyPokemon;

                if (player == null || enemy == null)
                {
                    Debug.LogError("Aucun ennemi actif → clic ignoré");
                    return;
                }

                // Dégâts
                enemy.pokemon.takeDamage(player.pokemon.getDegat());
                // Animation dégâts
                WodEnemy.SpawnDamageText(player.pokemon.getDegat(), WodEnemy.damagePoint.position);
                //Refresh de l'UI
                WodEnemy.Bind(SessionManager.Instance.selectedEnemyPokemon);

                // Vérifie si l'ennemi est mort
                if (!enemy.isAlive)
                {
                    // Donne l'XP au joueur
                    //bool leveledUp = player.pokemon.AjouterExperience(enemy.pokemon.expDonnee);
                    int xp = enemy.pokemon.GetExpGiven(player.pokemon.niveau);
                    bool leveledUp = player.pokemon.AjouterExperience(xp);

                    WodPlayer.Bind(SessionManager.Instance.selectedPlayerPokemon);

                    if (leveledUp)
                    {
                        Debug.Log($"{player.pokemon.nom} monte au niveau {player.pokemon.niveau} !");
                        // plus tard : animation, son, popup, etc.
                    }

                    // Respawn de l'ennemi
                    SessionManager.Instance.RespawnEnemyFromRoute();
                    WodEnemy.Bind(SessionManager.Instance.selectedEnemyPokemon);
                }
            }
        }
    }

    bool IsClickOnClickableArea()
    {
        PointerEventData pointerData = new PointerEventData(eventSystem);
        pointerData.position = Input.mousePosition;

        List<RaycastResult> results = new List<RaycastResult>();
        raycaster.Raycast(pointerData, results);

        if (results.Count == 0)
            return false;

        // On ne regarde QUE le premier élément touché (le plus haut visuellement)
        RaycastResult topHit = results[0];

        bool isClickable = ((1 << topHit.gameObject.layer) & clickableLayer) != 0;

        // Debug pour vérifier ce qu'on touche vraiment
        //Debug.Log($"TopHit: {topHit.gameObject.name} / Layer: {LayerMask.LayerToName(topHit.gameObject.layer)} / isClickable: {isClickable}");

        return isClickable;
    }
}
