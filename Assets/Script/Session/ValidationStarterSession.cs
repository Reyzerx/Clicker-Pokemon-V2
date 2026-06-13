using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text;
using System;
using UnityEngine.SceneManagement;

public class ValidationStarter : MonoBehaviour
{
    public CoreRefreshUI coreRefreshUI;

    public WODEnemy enemyWOD;
    public WODPlayer playerWOD;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void validerStarter(Pokemon starter) 
    {
        // core.setSelectedPokemon(pokemonIn);

        // On le met en session
        starter.estEquipe = true;
        SessionManager.Instance.InitPlayer(starter);
        SessionManager.Instance.addToPlayerEquipePokemon(starter);
        // Maintenant on met à jour l’UI
        playerWOD.Bind(SessionManager.Instance.selectedPlayerPokemon);

        SessionManager.Instance.selectedRoute = SessionManager.Instance.listeDeRoutes[0];
        SessionManager.Instance.InitEnemyFromRoute();
        // Maintenant on met à jour l’UI
        enemyWOD.Bind(SessionManager.Instance.selectedEnemyPokemon);

        coreRefreshUI.afficherSceneJeu(true);

        Debug.Log("selectedPokemon >" + JsonUtility.ToJson(SessionManager.Instance.selectedPlayerPokemon));
        Debug.Log("selectedEnemyPokemon >" + JsonUtility.ToJson(SessionManager.Instance.selectedEnemyPokemon));

        // TODO plus tard : ici on pourra sauvegarder la session dans un JSON
    }

}
